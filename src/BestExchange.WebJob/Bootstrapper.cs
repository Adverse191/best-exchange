using BestExchange.Common.IoC;
using BestExchange.WebJob.Core;

namespace BestExchange.WebJob
{
    internal class Bootstrapper
    {
        private IContainer _container;

        public Bootstrapper(IContainer container)
        {
            _container = container;
        }

        internal void Run()
        {
            BankInformationAgentManager manager = new BankInformationAgentManager(_container);
            manager.UpdateCurrencyInformation();
        }
    }
}
