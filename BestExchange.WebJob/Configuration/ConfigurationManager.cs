using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using BestExchange.WebJob.Configuration.ConfigurationEntities;

namespace BestExchange.WebJob.Configuration
{
    internal class FileConfigurationManager : IConfigurationManager
    {
        private const string AgentsSectionName = "agentsConfigSection";

        public IEnumerable<AgentElement> GetAgentsConfiguration()
        {
            AgentsSection agentsSection = (AgentsSection)ConfigurationManager.GetSection(AgentsSectionName);
            return agentsSection.Agents.OfType<AgentElement>();
        }
    }
}
