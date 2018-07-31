using System;
using System.Threading;
using System.Threading.Tasks;

namespace MicroObjectsLib.Threading
{
    public sealed class SemaphoreSlimBookEnd : ISemaphoreSlimBookEnd
    {
        private readonly SemaphoreSlim _semaphoreSlim;

        public SemaphoreSlimBookEnd() : this(new SemaphoreSlim(1)) { }

        private SemaphoreSlimBookEnd(SemaphoreSlim semaphoreSlim) => _semaphoreSlim = semaphoreSlim;

        private async Task Wait() => await _semaphoreSlim.WaitAsync();

        private void Release() => _semaphoreSlim.Release();

        public async Task<T> Lock<T>(Func<Task<T>> locked)
        {
            try
            {
                await Wait();
                return await locked();
            }
            finally
            {
                Release();
            }
        }

        public async Task Lock(Action locked)
        {
            try
            {
                await Wait();
                locked();
            }
            finally
            {
                Release();
            }
        }
    }

    public interface ISemaphoreSlimBookEnd
    {
        Task<T> Lock<T>(Func<Task<T>> locked);
        Task Lock(Action locked);
    }
}