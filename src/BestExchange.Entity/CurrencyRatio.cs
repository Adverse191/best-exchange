namespace BestExchange.Entity
{
    public class CurrencyRatio
    {
        public decimal BuyCurencyRate { get; set; }
        public decimal SaleCurencyRate { get; set; }
        public string BaseCurrency { get; set; }
        public string TargetCurrency { get; set; }
    }
}
