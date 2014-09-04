using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace BestExchange.WebJob.Core.BankAgents
{
    internal class BelaruskyNarodnyBankAgent : IBankAgent
    {
        private const string DataUrl = "http://bnb.by/currencies/ActualRates.xml";

        private IDataParser _dataParser;
        

        public BelaruskyNarodnyBankAgent(IDataParser dataParser)
        {
            _dataParser = dataParser;
        }

        public IEnumerable<FilialInformation> GetFilialsInformation()
        {
            using (WebClient client = new WebClient())
            {
                byte[] rawData = client.DownloadData(DataUrl);
                return _dataParser.ParseFilialInformations(rawData);
            }
        }
    }
}
