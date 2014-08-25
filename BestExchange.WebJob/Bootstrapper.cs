using BestExchange.Common.IoC;
using BestExchange.WebJob.Contract;
using BestExchange.WebJob.Core;
using BestExchange.WebJob.Core.Configuration;

namespace BestExchange.WebJob
{
    internal class Bootstrapper
    {
        private IContainer _container;
        private IAgentManager _agentManager;

        public Bootstrapper(IContainer container)
        {
            _container = container;
        }

        public void InitializeContainer()
        {
            _container.RegisterType<IObjectConstructor, ObjectConstructor>()
                .RegisterType<IConfigurationManager, FileConfigurationManager>()
                .RegisterType<IAgentManager, AgentManager>();
        }

        public void Run()
        {
            _agentManager = _container.ResolveType<IAgentManager>();
            
            foreach (IAgent agent in _agentManager.GetAgents())
            {
                agent.Run();       
            }
        }

        public void Stop()
        {
            foreach (IAgent agent in _agentManager.GetAgents())
            {
                agent.Stop();
            }
        }
    }
}
