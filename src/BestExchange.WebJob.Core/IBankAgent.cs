using System.Collections.Generic;
using BestExchange.Entity;

namespace BestExchange.WebJob.Core
{
    interface IBankAgent
    {
        IEnumerable<FilialInformation> GetFilialsInformation();
    }
}
