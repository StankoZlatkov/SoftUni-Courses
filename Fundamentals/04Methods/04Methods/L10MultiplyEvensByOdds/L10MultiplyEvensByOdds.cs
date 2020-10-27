using System;

namespace L10MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);

            int sum = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(sum);
        }

        public static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            int evenDigits = 0;

            while (input != 0)
            {
                evenDigits = input % 10;
                input /= 10;
                if (evenDigits % 2 == 0)
                {
                    evenSum += evenDigits;
                }
            }
            return evenSum;
        }
        public static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;
            int oddDigits = 0;

            while (input != 0)
            {
                oddDigits = input % 10;
                input /= 10;
                if (oddDigits % 2 != 0)
                {
                    oddSum += oddDigits;
                }
            }
            return oddSum;
        }
        public static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }
    }
}
