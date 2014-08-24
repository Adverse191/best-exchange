using System.Collections.Generic;
using BestExchange.WebJob.Contract;

namespace BestExchange.WebJob
{
    internal interface IAgentManager
    {
        IEnumerable<IAgent> GetAgents();
    }
}