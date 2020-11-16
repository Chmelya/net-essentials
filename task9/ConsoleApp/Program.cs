using System;
using StringParserLibarary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringParser sp = new StringParser();

            sp.OnStringContainsBLetter += Sp_OnStringContainsBLetter;
            sp.OnStringContainsZLetter += Sp_OnStringContainsZLetter;

            sp.Parse("asdsadasdZBbzzdsad");
        }

        private static void Sp_OnStringContainsZLetter(object sender, StringEventArguments e)
        {
            Console.WriteLine($"number of occurrences {e.Letter}: {e.Count}");
        }

        private static void Sp_OnStringContainsBLetter(object sender, StringEventArguments e)
        {
            Console.WriteLine($"number of occurrences {e.Letter}: {e.Count}");
        }
    }
}
