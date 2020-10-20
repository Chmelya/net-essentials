using System;
using System.Collections.Generic;
using System.Linq;

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

            var selectedItem = cacheList.FirstOrDefault(i => i.Key.Equals(key));

            cacheList.Remove(selectedItem);
            
            cacheList.Add(new CacheItem<TKey, TValue>(key, value, expiresOn));
        }

        public TValue Get(TKey key)
        {
            var selectedItem = cacheList.FirstOrDefault(i => i.Key.Equals(key));

            if (selectedItem.Time > DateTime.Now)
            {
                return selectedItem.Value;
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            var selectedItem = cacheList.FirstOrDefault(i => i.Key.Equals(key));

            if (cacheList.Remove(selectedItem))
            {
                return true;
            }

            return false;
        }
    }
}
