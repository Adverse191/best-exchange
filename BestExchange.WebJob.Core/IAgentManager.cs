using System.Collections.Generic;
using BestExchange.WebJob.Contract;

namespace BestExchange.WebJob.Core
{
    public interface IAgentManager
    {
        IEnumerable<IAgent> GetAgents();
    }
}