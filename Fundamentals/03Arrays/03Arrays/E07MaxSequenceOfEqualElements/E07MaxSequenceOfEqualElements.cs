using System;
using System.Linq;

namespace E07MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxCount = int.MinValue; ;
            int num = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int count = 0;

                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > maxCount)
                {
                    num = inputArray[i];
                    maxCount = count;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
