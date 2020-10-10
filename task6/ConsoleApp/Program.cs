using System;
using CacheLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cache<double, string> cache = new Cache<double, string>();

            cache.AddOrUpdate(1, "hello", DateTime.Now.AddSeconds(5));

            cache.AddOrUpdate(2, "world", DateTime.Now.AddHours(2));

            System.Threading.Thread.Sleep(7000);

            var getA = cache.Get(1); //null
            var getB = cache.Get(2); //world
            cache.Remove(2);

            cache.AddOrUpdate(1, "!", DateTime.Now.AddDays(1));
            var getC = cache.Get(1); // !
            Console.WriteLine(getC);
        }
    }
}
