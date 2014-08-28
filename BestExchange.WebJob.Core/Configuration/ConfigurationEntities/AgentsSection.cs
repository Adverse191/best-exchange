using System.Configuration;

namespace BestExchange.WebJob.Core.Configuration.ConfigurationEntities
{
    public class AgentsSection : ConfigurationSection
    {
        [ConfigurationProperty("agents")]
        public AgentsCollection Agents
        {
            get { return ((AgentsCollection)(base["agents"])); }
        }
    }
}
