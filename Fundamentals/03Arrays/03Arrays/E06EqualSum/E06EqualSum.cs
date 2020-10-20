using System;
using System.Linq;

namespace E06EqualSum
{
    class EqualSum
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isEqual = false;
            int indexOfEqualElement = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int r = 0; r <= i - 1; r++)
                {
                    rightSum += inputArray[r];
                }
                for (int l = i + 1; l < inputArray.Length; l++)
                {
                    leftSum += inputArray[l];
                }

                if (rightSum == leftSum)
                {
                    isEqual = true;
                    indexOfEqualElement = i;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine(indexOfEqualElement);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
