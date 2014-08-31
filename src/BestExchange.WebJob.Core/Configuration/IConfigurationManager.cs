using System.Collections.Generic;
using BestExchange.WebJob.Core.Configuration.ConfigurationEntities;

namespace BestExchange.WebJob.Core.Configuration
{
    public interface IConfigurationManager
    {
        IEnumerable<AgentElement> GetAgentsConfiguration();
    }
}
