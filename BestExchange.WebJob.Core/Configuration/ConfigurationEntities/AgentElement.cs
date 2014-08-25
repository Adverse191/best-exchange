using System.Configuration;

namespace BestExchange.WebJob.Core.Configuration.ConfigurationEntities
{
    public class AgentElement : ConfigurationElement
    {
        [ConfigurationProperty("type", IsKey = true, IsRequired = true)]
        public string Type
        {
            get { return ((string)(base["type"])); }
            set { base["type"] = value; }
        }
    }
}
