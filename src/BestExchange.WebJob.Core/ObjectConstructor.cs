using System;

namespace BestExchange.WebJob.Core
{
    public class ObjectConstructor : IObjectConstructor
    {
        public T CreateObjectInstance<T>(string fullTypeName)
            where T : class 
        {
            Type type = Type.GetType(fullTypeName);

            if (type != null)
            {
                T instance = Activator.CreateInstance(type) as T;
                return instance;
            }

            return null;
        }
    }
}
