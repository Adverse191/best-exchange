using System.Collections.Generic;
using BestExchange.Entity;

namespace BestExchange.Dal
{
    public interface IBankRepository
    {
        void CreateOrUpdate(IEnumerable<FilialInformation> filialInformation);
    }
}
