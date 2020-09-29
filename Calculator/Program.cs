using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            try
            {
                if (check(args[0]) && check(args[1]))
                {
                    a = Convert.ToDouble(args[0]);
                    b = Convert.ToDouble(args[1]);
                    switch (args[2])
                    {
                        case "M":
                            Console.WriteLine(Convert.ToDouble(a * b));
                            break;
                        case "D":
                            Console.WriteLine(Convert.ToDouble(a / b));
                            break;
                        case "A":
                            Console.WriteLine(a - b);
                            break;
                        case "S":
                            Console.WriteLine(a + b);
                            break;
                        default:
                            Console.WriteLine("incorrect operation");
                            break;
                    }
                }
                else
                    Console.WriteLine("error");
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        static bool check(string s)
        {
            var buf = s.Split(',');
            if (buf.Length > 1)
                if (buf[1].Length > 5)
                {
                    return false;
                }

            if (Math.Abs(Convert.ToDouble(buf[0])) > 10000)
                return false;

            //if (Math.Abs(Convert.ToDouble(s.Split('.')[0])) <= 10000 && s.Split('.')[1].Length <= 5)
                //return true;

            return true;
        }
    }
}
