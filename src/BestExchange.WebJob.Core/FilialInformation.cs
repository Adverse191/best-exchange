using System.Collections.Generic;
using System.Globalization;

namespace BestExchange.WebJob.Core
{
    internal class FilialInformation
    {
        public string Address { get; set; }
        public IEnumerable<CurrencyRatio> CurrencyRatios { get; set; }
    }
}
