using System.Collections.Generic;
using BestExchange.Entity;

namespace BestExchange.WebJob.Core
{
    interface IDataParser
    {
        IEnumerable<FilialInformation> ParseFilialInformations(byte[] rawData);
    }
}
