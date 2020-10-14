using System;
using System.Collections.Generic;
using System.Text;

namespace CacheLibrary
{
    struct CacheItem<TKey, TValue>
        where TKey : struct
        where TValue : class
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public DateTime Time { get; set; }

        public CacheItem(TKey key, TValue value, DateTime time)
        {
            Key = key;
            Value = value;
            Time = time; 
        }
    }
}
