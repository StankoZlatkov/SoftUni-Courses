using System;
using System.Linq;

namespace L08CondenseArrayOoNumber
{
    class CondenseArrayOoNumber
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int length = inputArray.Length;

            while (length >= 1)
            {
                int[] outputArray = new int[length - 1];
                for (int i = 0; i < outputArray.Length; i++)
                {
                    outputArray[i] = inputArray[i] + inputArray[i + 1];
                    inputArray[i] = outputArray[i];
                }

                length--;
            }

            Console.WriteLine(inputArray[0]);
        }
    }
}
