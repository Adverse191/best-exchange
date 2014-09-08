using System.Collections.Generic;
using BestExchange.Common.IoC;
using BestExchange.Entity;
using BestExchange.WebJob.Core.BankAgents;

namespace BestExchange.WebJob.Core
{
    public class BankInformationAgentManager
    {
        private IContainer _container;

        public BankInformationAgentManager(IContainer container)
        {
            _container = container;
            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            _container.RegisterType<IBankAgent, BelaruskyNarodnyBankAgent>("BelaruskyNarodnyBankAgent");
        }

        public void UpdateCurrencyInformation()
        {
            List<FilialInformation> filialInformations = new List<FilialInformation>();
            IEnumerable<IBankAgent> bankAgents = _container.ResolveType<IBankAgent[]>();
            
            foreach (IBankAgent agent in bankAgents)
            {
                IEnumerable<FilialInformation> infos = agent.GetFilialsInformation();
                filialInformations.AddRange(infos);
            }
        }
    }
}
