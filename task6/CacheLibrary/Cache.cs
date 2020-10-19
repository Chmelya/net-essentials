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

            var selectedItem = from item in cacheList where item.Key.Equals(key) select item;

            foreach (var item in selectedItem)
            {
                cacheList.Remove(item);
            }

            cacheList.Add(new CacheItem<TKey, TValue>(key, value, expiresOn));
        }

        public TValue Get(TKey key)
        {
            var selectedItem = from item in cacheList where item.Key.Equals(key) select item;

            foreach (var item in selectedItem)
            {
                return item.Time > DateTime.Now ? item.Value : null;
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            var selectedItem = from item in cacheList where item.Key.Equals(key) select item;

            foreach (var item in selectedItem)
            {
                cacheList.Remove(item);
                return true;
            }

            return false;
        }
    }
}
