using System;

namespace Calculator
{
    class Calculator
    {
        public static void Slove(string x, string y, string operation)
        {
            double a;
            double b;

            if (CalculatorHelper.CheckNumCondition(x) && CalculatorHelper.CheckNumCondition(y))
            {
                double.TryParse(x, out a);
                double.TryParse(y, out b);

                switch (operation)
                {
                    case "M":
                        Console.WriteLine(a * b);
                        break;
                    case "D":
                        Console.WriteLine(a / b);
                        break;
                    case "A":
                        Console.WriteLine(a - b);
                        break;
                    case "S":
                        Console.WriteLine(a + b);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
                Console.WriteLine("error");
        }
    }
}
