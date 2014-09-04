using System.Collections.Generic;

namespace BestExchange.WebJob.Core
{
    interface IBankAgent
    {
        IEnumerable<FilialInformation> GetFilialsInformation();
    }
}
