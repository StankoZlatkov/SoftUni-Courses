using System;
using System.Linq;

namespace E02CommonElements
{
    class CommonElements
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var secondElement in secondArray)
            {
                foreach (var firstElement in firstArray)
                {
                    if (secondElement == firstElement)
                    {
                        Console.Write($"{secondElement} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
