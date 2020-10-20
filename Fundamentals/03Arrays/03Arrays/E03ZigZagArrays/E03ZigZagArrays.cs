using System;
using System.Linq;

namespace E03ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lines];
            int[] secondArray = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] inputIntigers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if ((i + 1) % 2 != 0)
                {
                    firstArray[i] = inputIntigers[0];
                    secondArray[i] = inputIntigers[1];
                }
                else
                {
                    firstArray[i] = inputIntigers[1];
                    secondArray[i] = inputIntigers[0];
                }
            }

            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
