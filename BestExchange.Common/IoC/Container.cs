using Microsoft.Practices.Unity;

namespace BestExchange.Common.IoC
{
    public class Container : IContainer
    {
        private readonly IUnityContainer _container;

        public Container()
        {
            _container = new UnityContainer();
        }

        public IContainer RegisterType<TFrom, TTo>()
            where TFrom : class
            where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>();
            return this;
        }

        public T ResolveType<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
