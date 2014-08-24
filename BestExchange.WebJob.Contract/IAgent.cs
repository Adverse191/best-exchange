using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestExchange.WebJob.Contract
{
    public interface IAgent
    {
        void Run();
        void Stop();
    }
}
