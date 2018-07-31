using System;
using System.Threading.Tasks;

namespace MicroObjectsLib.Cache
{
    public interface ICache<T>
    {
        Task<T> Retrieve(Func<Task<T>> func);
        Task Clear();
    }
}