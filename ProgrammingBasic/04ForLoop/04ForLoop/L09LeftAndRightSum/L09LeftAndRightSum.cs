using System;

namespace L09LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i1 = 1; i1 <= num; i1++)
            {
                int leftNums = int.Parse(Console.ReadLine());
                leftSum += leftNums;
            }

            for (int i2 = 1; i2 <= num; i2++)
            {
                int rightNums = int.Parse(Console.ReadLine());
                rightSum += rightNums;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
