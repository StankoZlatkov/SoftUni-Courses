using System;
using System.Linq;

namespace E08MagicSum
{
    class MagicSum
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == sum)
                    {
                        Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
                        break;
                    }
                }
            }
        }
    }
}
