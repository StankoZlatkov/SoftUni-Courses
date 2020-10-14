using System;
using System.Linq;

namespace L05SumEvenNumbers
{
    class SumEvenNumbers
    {
        static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            foreach (var number in inputNumbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
