using System;
using System.Runtime.Caching;

namespace ProjetVelo
{
    public class GenericProxyCache<T>
    {
        private readonly ObjectCache cache;

        public GenericProxyCache()
        {
            cache = MemoryCache.Default;
        }

        public T Get(string cacheItemName)
        {
            return Get(cacheItemName, DateTimeOffset.Now.AddMinutes(10));
        }

        public T Get(string cacheItemName, double dtSeconds)
        {
            return Get(cacheItemName, DateTimeOffset.Now.AddSeconds(dtSeconds));
        }

        public T Get(string cacheItemName, DateTimeOffset dt)
        {
            T cachedItem = (T)cache[cacheItemName];

            if (cachedItem == null)
            {
                cachedItem = Activator.CreateInstance<T>();
                cache.Set(cacheItemName, cachedItem, dt);
            }

            return cachedItem;
        }
        public void Set(string cacheItemName, T item, DateTimeOffset dt)
        {
            // Ajouter l'élément au cache avec la clé spécifiée et la durée d'expiration
            cache.Set(cacheItemName, item, dt);
        }
    }
}