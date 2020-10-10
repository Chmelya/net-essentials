using System;
using System.Collections.Generic;
using System.Text;

namespace CacheLibrary
{
    public class Cache<TKey, TValue>: ICache<TKey, TValue>
        where TKey : struct
        where TValue : class
    {
        Dictionary<TKey, TValue> cacheVal;
        Dictionary<TKey, DateTime> cacheTime;

        public Cache()
        {
            cacheVal = new Dictionary<TKey, TValue>();
            cacheTime = new Dictionary<TKey, DateTime>();
        }

        public void AddOrUpdate(TKey key, TValue value, DateTime expiresOn)
        {
            if (cacheVal.ContainsKey(key))
            {
                cacheVal[key] = value;
                cacheTime[key] = expiresOn;
            }
            else
            {
                cacheVal.Add(key, value);
                cacheTime.Add(key, expiresOn);
            }
        }

        public TValue Get(TKey key)
        {
            if (cacheVal.ContainsKey(key))
                if (cacheVal[key] == null)
                    return null;

            if (DateTime.Now > cacheTime[key])
                return null;

            return cacheVal[key];
        }

        public bool Remove(TKey key)
        {
            if (!cacheVal.ContainsKey(key))
                return false;

            cacheVal.Remove(key);
            cacheTime.Remove(key);

            return true;
        }
    }
}
