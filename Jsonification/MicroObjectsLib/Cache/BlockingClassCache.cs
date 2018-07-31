using MicroObjectsLib.Threading;
using System;
using System.Threading.Tasks;

namespace MicroObjectsLib.Cache
{
    public sealed class BlockingClassCache<T> : ICache<T> where T : class
    {
        private readonly ISemaphoreSlimBookEnd _semaphore;
        private readonly ICache<T> _cache;

        public BlockingClassCache() : this(new SemaphoreSlimBookEnd(), new ClassCache<T>()) { }

        private BlockingClassCache(ISemaphoreSlimBookEnd semaphore, ICache<T> cache)
        {
            _semaphore = semaphore;
            _cache = cache;
        }

        public async Task<T> Retrieve(Func<Task<T>> func) => await _semaphore.Lock(async () => await _cache.Retrieve(func));

        public async Task Clear() => await _semaphore.Lock(() => _cache.Clear());

    }
}