using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using BestExchange.WebJob.Core.Configuration.ConfigurationEntities;

namespace BestExchange.WebJob.Core.Configuration
{
    public class FileConfigurationManager : IConfigurationManager
    {
        private const string AgentsSectionName = "agentsConfigSection";

        public IEnumerable<AgentElement> GetAgentsConfiguration()
        {
            AgentsSection agentsSection = (AgentsSection)ConfigurationManager.GetSection(AgentsSectionName);
            return agentsSection.Agents.OfType<AgentElement>();
        }
    }
}
