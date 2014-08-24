using System.Collections.Generic;
using BestExchange.WebJob.Configuration;
using BestExchange.WebJob.Configuration.ConfigurationEntities;
using BestExchange.WebJob.Contract;

namespace BestExchange.WebJob
{
    internal class AgentManager : IAgentManager
    {
        private IObjectConstructor _objectConstructor;
        private IConfigurationManager _configurationManager;

        public AgentManager(IObjectConstructor objectConstructor, IConfigurationManager configurationManager)
        {
            _objectConstructor = objectConstructor;
            _configurationManager = configurationManager;
        }

        public IEnumerable<IAgent> GetAgents()
        {
            IEnumerable<AgentElement> agentsConfiguration = _configurationManager.GetAgentsConfiguration();
            IList<IAgent> agents = new List<IAgent>();

            foreach (AgentElement agentElement in agentsConfiguration)
            {
                IAgent agent = _objectConstructor.CreateObjectInstance<IAgent>(agentElement.Type);
                agents.Add(agent);
            }

            return agents;
        }
    }
}
