using System.Diagnostics;
using BestExchange.Common.IoC;
using BestExchange.WebJob.Contract;

namespace BestExchange.WebJob.CurrencyRateAgent
{
    public class Agent : IAgent
    {
        private IContainer _container;

        public void Invoke()
        {

        }

        public void Initialize(IContainer container)
        {
            _container = container;
        }
    }
}
