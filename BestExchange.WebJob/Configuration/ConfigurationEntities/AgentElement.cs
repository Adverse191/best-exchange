using System.Configuration;

namespace BestExchange.WebJob.Configuration.ConfigurationEntities
{
    internal class AgentElement : ConfigurationElement
    {
        [ConfigurationProperty("type", IsKey = true, IsRequired = true)]
        public string Type
        {
            get { return ((string)(base["type"])); }
            set { base["type"] = value; }
        }
    }
}
