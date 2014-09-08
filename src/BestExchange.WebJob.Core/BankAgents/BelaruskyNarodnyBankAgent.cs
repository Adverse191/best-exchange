using System.Collections.Generic;
using System.Net;
using BestExchange.Entity;

namespace BestExchange.WebJob.Core.BankAgents
{
    internal class BelaruskyNarodnyBankAgent : IBankAgent
    {
        private const string DataUrl = "http://bnb.by/currencies/ActualRates.xml";
        private const string BankName = "BelaruskyNarodnyBank";
        private IDataParser _dataParser;
        private Bank _bank;

        public BelaruskyNarodnyBankAgent(IDataParser dataParser)
        {
            _dataParser = dataParser;
            _bank = new Bank {Name = BankName};
        }

        public IEnumerable<FilialInformation> GetFilialsInformation()
        {
            using (WebClient client = new WebClient())
            {
                byte[] rawData = client.DownloadData(DataUrl);
                IEnumerable<FilialInformation> filialInformations = _dataParser.ParseFilialInformations(rawData);

                foreach (FilialInformation filialInformation in filialInformations)
                {
                    filialInformation.Bank = _bank;
                }

                return filialInformations;
            }
        }
    }
}
