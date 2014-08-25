namespace BestExchange.WebJob.Core
{
    public interface IObjectConstructor
    {
        T CreateObjectInstance<T>(string fullTypeName)
            where T : class;
    }
}
