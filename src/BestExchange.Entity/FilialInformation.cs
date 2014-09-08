using System.Collections.Generic;

namespace BestExchange.Entity
{
    public class FilialInformation
    {
        public string Address { get; set; }
        public Bank Bank { get; set; }
        public IEnumerable<CurrencyRatio> CurrencyRatios { get; set; }
    }
}
