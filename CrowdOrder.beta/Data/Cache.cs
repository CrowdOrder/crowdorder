using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class Cache : IDisposable
    {
        private readonly IMemoryCache cache;

        private bool disposed = false;

        public Cache()
        {
            cache = new MemoryCache(new MemoryCacheOptions());
        }

        public T Memoize<T>(string key, Func<T> getValueFunc, TimeSpan absoluteExpirationRelativeToNow)
        {
            if (!cache.TryGetValue<T>(key, out var value))
            {
                value = getValueFunc();
                cache.Set(key, value, absoluteExpirationRelativeToNow);
            }

            return value;
        }

        public void Remove(string key)
        {
            cache.Remove(key);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                cache.Dispose();
            }

            disposed = true;
        }
    }
}
