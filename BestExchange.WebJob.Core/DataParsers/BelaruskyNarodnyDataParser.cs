using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BestExchange.WebJob.Core.DataParsers
{
    internal class BelaruskyNarodnyDataParser : IDataParser
    {
        private const short IsoStringLength = 3;
        private const string NativeRegionCurrency = "BR";

        public IEnumerable<FilialInformation> ParseFilialInformations(byte[] rawData)
        {
            string dataAsString = Encoding.Default.GetString(rawData);
            List<FilialInformation> filialInformations = new List<FilialInformation>();

            XDocument data = XDocument.Parse(dataAsString);
            IEnumerable<XElement> filials = data.Root.Elements("filials").Elements("filial");
            
            foreach (XElement filial in filials)
            {
                string address = filial.Element("address").Value;
                FilialInformation filialInformation = new FilialInformation();
                filialInformation.Address = address;
                List<CurrencyRatio> currencyRatios = new List<CurrencyRatio>();
                IEnumerable<XElement> rates = filial.Elements("rates");

                foreach (XElement rate in rates)
                {
                    if (!rate.HasElements)
                    {
                        continue;
                    }

                    IEnumerable<XElement> values = rate.Elements("value");

                    foreach (XElement value in values)
                    {
                        CurrencyRatio ratio = new CurrencyRatio();
                        ratio.BuyCurencyRate = decimal.Parse(value.Attribute("buy").Value);
                        ratio.SaleCurencyRate = decimal.Parse(value.Attribute("sale").Value);
                        string iso = value.Attribute("iso").Value;

                        if (IsConversionRate(iso))
                        {
                            ratio.BaseCurrency = iso.Substring(0, 3);
                            ratio.TargetCurrency = iso.Substring(3, 3);
                        }
                        else
                        {
                            ratio.BaseCurrency = NativeRegionCurrency;
                            ratio.TargetCurrency = iso;
                        }

                        currencyRatios.Add(ratio);
                    }
                }

                filialInformation.CurrencyRatios = currencyRatios;
                filialInformations.Add(filialInformation);
            }

            return filialInformations;
        }

        private static bool IsConversionRate(string iso)
        {
            return iso.Length == IsoStringLength * 2;
        }
    }
}
