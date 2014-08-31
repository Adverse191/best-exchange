using BestExchange.Common.IoC;

namespace BestExchange.WebJob.Contract
{
    public interface IAgent
    {
        void Initialize(IContainer container);
        void Invoke();
    }
}
