using System;

namespace Calculator
{
    static class CalculatorHelper
    {
        public static bool CheckNumCondition(string s)
        {
            var buf = s.Split('.');

            if (buf.Length > 1)
                if (buf[1].Length > 5)
                {
                    return false;
                }

            if (Math.Abs(Convert.ToDouble(buf[0])) > 10000)
                return false;

            return true;
        }

    }
}
