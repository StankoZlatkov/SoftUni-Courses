using System;
using System.Linq;

namespace L06EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            foreach (var number in inputNumbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
