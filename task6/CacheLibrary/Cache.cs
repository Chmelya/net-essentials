using System;
using System.Collections.Generic;
using System.Text;

namespace CacheLibrary
{
    public class Cache<TKey, TValue>: ICache<TKey, TValue>
        where TKey : struct
        where TValue : class
    {
        
        List<CacheItem<TKey, TValue>> cacheList;

        public Cache()
        {
            cacheList = new List<CacheItem<TKey, TValue>>();
        }

        public void AddOrUpdate(TKey key, TValue value, DateTime expiresOn)
        {
            for (int i = cacheList.Count - 1; i >= 0; i--)
            {
                if (cacheList[i].Key.Equals(key))
                {
                    cacheList.Remove(cacheList[i]);
                    break;
                }
            }

            cacheList.Add(new CacheItem<TKey, TValue>(key, value, expiresOn));
        }

        public TValue Get(TKey key)
        {
            foreach (var item in cacheList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Time > DateTime.Now ? item.Value : null;
                }
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            for (int i = cacheList.Count - 1; i >= 0; i--)
            {
                if (cacheList[i].Key.Equals(key))
                {
                    cacheList.Remove(cacheList[i]);
                    return true;
                }
            }

            return false;
        }
    }
}
