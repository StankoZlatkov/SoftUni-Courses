using System;
using System.Linq;

namespace E04ArrayRotation
{
    class ArrayRotation
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrrayRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrrayRotations; i++)
            {
                int firstElement = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[inputArray.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(' ', inputArray));
        }
    }
}
