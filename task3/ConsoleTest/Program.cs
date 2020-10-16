using System;
using MoneyLib;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Money(100, Currencies.USD);
            var m2 = new Money(200, Currencies.EUR);

            var m3 = m1 + m2;
            var m4 = m2 + m1;

            m1++;
            m2++;

            var m5 = new Money(100, Currencies.BYN);
            m5++;

            string s = (string)m3;
            int x = m1;
        }
    }
}
