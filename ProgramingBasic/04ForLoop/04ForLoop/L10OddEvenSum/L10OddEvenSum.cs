using System;

namespace L10OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= num; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inputNum;
                }
                else
                {
                    oddSum += inputNum;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
