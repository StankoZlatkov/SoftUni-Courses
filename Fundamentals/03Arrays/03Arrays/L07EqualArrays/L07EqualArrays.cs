using System;
using System.Linq;

namespace L07EqualArrays
{
    class EqualArrays
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int indexOfDifference = -1;
            bool areEqual = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                indexOfDifference = i;

                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                int arraySum = firstArray.Sum();
                Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexOfDifference} index");    
            }
        }
    }
}
