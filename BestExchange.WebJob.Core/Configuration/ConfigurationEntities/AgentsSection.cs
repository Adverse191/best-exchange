using System.Configuration;

namespace BestExchange.WebJob.Core.Configuration.ConfigurationEntities
{
    internal class AgentsSection : ConfigurationSection
    {
        [ConfigurationProperty("agentsConfigSection")]
        public AgentsCollection Agents
        {
            get { return ((AgentsCollection)(base["agentsConfigSection"])); }
        }
    }
}
