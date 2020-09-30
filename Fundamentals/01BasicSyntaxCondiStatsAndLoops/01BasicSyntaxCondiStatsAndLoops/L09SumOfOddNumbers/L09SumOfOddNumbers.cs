using System;

namespace L09SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int oddNumber = -1;
            int sum = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                oddNumber += 2;
                sum += oddNumber;
                Console.WriteLine(oddNumber);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
