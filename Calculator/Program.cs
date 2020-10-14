using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            try
            {
                Calculator.Slove(args[0], args[1], args[2]);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
