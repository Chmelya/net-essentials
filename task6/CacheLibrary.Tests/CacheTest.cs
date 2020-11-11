using NUnit.Framework;
using CacheLibrary;
using System;

namespace CacheLibrary.Tests
{
    public class CacheTest
    {
        ICache<double, string> cache;
         
        [SetUp]
        public void Setup()
        {
            cache = new Cache<double, string>();
        }

        [Test]
        public void Add_1_hello()
        {
            cache.AddOrUpdate(1, "hello", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("hello", cache.Get(1));
        }

        [Test]
        public void Update_1_hello()
        {
            cache.AddOrUpdate(2, "hello", DateTime.Now.AddSeconds(5));
            cache.AddOrUpdate(2, "hell", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("hell", cache.Get(2));
        }

        [Test]
        public void Remove_returnFalse()
        {
            cache.AddOrUpdate(3, "world", DateTime.Now.AddSeconds(5));

            Assert.IsFalse(cache.Remove(4));
        }

        [Test]
        public void Remove_returnTrue()
        {
            cache.AddOrUpdate(5, "world", DateTime.Now.AddSeconds(5));

            Assert.IsTrue(cache.Remove(5));
        }

        [Test]
        public void Get()
        {
            cache.AddOrUpdate(6, "six", DateTime.Now.AddSeconds(5));

            Assert.AreEqual("six", cache.Get(6));
        }
    }
}