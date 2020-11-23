using System;
using System.Linq;

namespace L01RecursiveArraySum
{
    class RecursiveArraySum
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arraySum = GetArraySum(inputArray, 0);

            Console.WriteLine(arraySum);
        }

        public static int GetArraySum(int[] inputArray, int index)
        {
            if (index == inputArray.Length - 1)
            {
                return inputArray[index];
            }

            return inputArray[index] + GetArraySum(inputArray, index + 1);
        }
    }
}
