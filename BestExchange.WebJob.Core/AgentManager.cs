using System.Collections.Generic;
using BestExchange.WebJob.Contract;
using BestExchange.WebJob.Core.Configuration;
using BestExchange.WebJob.Core.Configuration.ConfigurationEntities;

namespace BestExchange.WebJob.Core
{
    public class AgentManager : IAgentManager
    {
        private IObjectConstructor _objectConstructor;
        private IConfigurationManager _configurationManager;
        private IEnumerable<IAgent> _agents;
 
        public AgentManager(IObjectConstructor objectConstructor, IConfigurationManager configurationManager)
        {
            _objectConstructor = objectConstructor;
            _configurationManager = configurationManager;
        }

        public IEnumerable<IAgent> Agents
        {
            get
            {
                //TODO: Thread safe?
                if (_agents == null)
                {
                    _agents = CreateAgents();
                }

                return _agents;
            }
        }

        private IEnumerable<IAgent> CreateAgents()
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
