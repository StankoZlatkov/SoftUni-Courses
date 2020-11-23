using System;

namespace L07RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long fibonacci = CalcFibonacci(n);

            Console.WriteLine(fibonacci);
        }

        private static long CalcFibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return CalcFibonacci(n - 1) + CalcFibonacci(n - 2);
        }
    }
}