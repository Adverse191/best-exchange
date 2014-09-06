using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestExchange.WebJob.Core
{
    interface IDataParser
    {
        IEnumerable<FilialInformation> ParseFilialInformations(byte[] rawData);
    }
}
