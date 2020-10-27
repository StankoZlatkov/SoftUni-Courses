using System;

namespace E08FactorialDivision
{
    class FactorialDivision
    {
        static void Main()
        {
            double first = int.Parse(Console.ReadLine());
            double second = int.Parse(Console.ReadLine());

            double result = GetFactorial(first) / GetFactorial(second);
            Console.WriteLine($"{result:f2}");
        }
        public static double GetFactorial(double number)
        {
            if (number == 0)
            {
                number = 1;
            }
            double result = number;

            for (long i = (long)number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
