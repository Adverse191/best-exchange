namespace BestExchange.Common.IoC
{
    public interface IContainer
    {
        IContainer RegisterType<TFrom, TTo>()
            where TFrom : class
            where TTo : TFrom;

        IContainer RegisterType<TFrom, TTo>(string name)
            where TFrom : class
            where TTo : TFrom;

        T ResolveType<T>();
    }
}
