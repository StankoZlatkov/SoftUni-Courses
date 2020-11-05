using System;
using System.Linq;

namespace L04LargestThreeNumbers
{
    class LargestThreeNumbers
    {
        static void Main()
        {
            var inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                if (i == inputList.Length)
                {
                    break;
                }
                Console.Write($"{inputList[i]} ");
            }
            Console.WriteLine();
        }
    }
}
