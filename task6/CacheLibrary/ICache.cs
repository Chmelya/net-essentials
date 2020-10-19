using System;

namespace CacheLibrary
{
    public interface ICache<TKey, TValue>
        where TKey : struct
        where TValue : class
    {
        void AddOrUpdate(TKey key, TValue value, DateTime expiresOn);

        TValue Get(TKey key);

        bool Remove(TKey key);
    }
}
