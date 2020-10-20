using System;
using System.Linq;

namespace E05TopIntegers
{
    class TopIntegers
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
