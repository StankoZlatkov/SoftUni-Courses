using System;

namespace E10TopNumber
{
    class E10TopNumber
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 1; i <= input; i++)
            {
                bool maxNumber = IsLeastOddDigit(i) && IsМaxSumDevisibleByEight(i);
                if (maxNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsМaxSumDevisibleByEight(int number)
        {
            bool devisibleByEight = false;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                devisibleByEight = true;
            }
            return devisibleByEight;
        }
        public static bool IsLeastOddDigit(int number)
        {
            bool isOdd = false;
            int digit = 0;
            while (number != 0)
            {
                digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }
            return isOdd;
        }
    }
}
