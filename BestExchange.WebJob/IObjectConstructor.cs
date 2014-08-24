namespace BestExchange.WebJob
{
    internal interface IObjectConstructor
    {
        T CreateObjectInstance<T>(string fullTypeName)
            where T : class;
    }
}
