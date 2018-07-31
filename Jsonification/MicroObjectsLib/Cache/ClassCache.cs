using System;
using System.Threading.Tasks;

namespace MicroObjectsLib.Cache
{
    public sealed class ClassCache<T> : ICache<T> where T : class
    {
        private T _cache;

        public async Task<T> Retrieve(Func<Task<T>> func) => _cache ?? (_cache = await func());

        public Task Clear() => Task.Run(() => _cache = null);
    }
}