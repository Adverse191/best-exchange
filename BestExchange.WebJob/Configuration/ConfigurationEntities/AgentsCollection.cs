using System.Configuration;

namespace BestExchange.WebJob.Configuration.ConfigurationEntities
{
    [ConfigurationCollection(typeof(AgentElement), AddItemName = "agent")]
    internal class AgentsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new AgentElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((AgentElement)(element)).Type;
        }
    }
}
