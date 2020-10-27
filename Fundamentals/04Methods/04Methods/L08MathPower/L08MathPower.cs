using System;

namespace L08MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double result = GetNumberPow(number, pow);
            Console.WriteLine(result);
        }

        public static double GetNumberPow(double number, int pow)
        {
            double result = number;
            for (int i = 1; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
