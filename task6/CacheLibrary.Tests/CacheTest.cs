using NUnit.Framework;
using CacheLibrary;
using System;
using System.Threading;

namespace CacheLibrary.Tests
{
    public class CacheTests
    {
        ICache<double, string> cache;
         
        [SetUp]
        public void Setup()
        {
            cache = new Cache<double, string>();
        }

        [Test]
        public void AddOrUpdate_AddedItemDoesNotExistInCache_ShouldAddNewItem()
        {
            cache.AddOrUpdate(1, "hello", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("hello", cache.Get(1));
        }

        [Test]
        public void AddOrUpdate_AddedItemExistInCache_ShouldUpdateItem()
        {
            cache.AddOrUpdate(2, "hello", DateTime.Now.AddSeconds(5));
            cache.AddOrUpdate(2, "hell", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("hell", cache.Get(2));
        }

        [Test]
        public void RemoveItem_ItemExistInCache_ShouldReturnFalse()
        {
            cache.AddOrUpdate(3, "world", DateTime.Now.AddSeconds(5));

            Assert.IsFalse(cache.Remove(4));
        }

        [Test]
        public void RemoveItem_ItemExistInCache_ShouldReturnTrue()
        {
            cache.AddOrUpdate(5, "world", DateTime.Now.AddSeconds(5));

            Assert.IsTrue(cache.Remove(5));
        }

        [Test]
        public void GetItem_ItemExistInCache_ShouldReturnItem()
        {
            cache.AddOrUpdate(6, "six", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("six", cache.Get(6));
        }

        [Test]
        public void GetItem_ItemExpired_ShouldNotReturnItem()
        {
            cache.AddOrUpdate(7, "seven", DateTime.Now.AddSeconds(1));

            Thread.Sleep(1200);

            Assert.AreEqual(null, cache.Get(7));
        }
    }
}