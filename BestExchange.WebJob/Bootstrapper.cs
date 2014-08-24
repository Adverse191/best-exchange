using BestExchange.Common.IoC;
using BestExchange.WebJob.Configuration;

namespace BestExchange.WebJob
{
    internal class Bootstrapper
    {
        private IContainer _container;

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
            
        }

        public void Stop()
        {
            
        }
    }
}
