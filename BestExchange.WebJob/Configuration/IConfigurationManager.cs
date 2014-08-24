using System.Collections.Generic;
using BestExchange.WebJob.Configuration.ConfigurationEntities;

namespace BestExchange.WebJob.Configuration
{
    internal interface IConfigurationManager
    {
        IEnumerable<AgentElement> GetAgentsConfiguration();
    }
}
