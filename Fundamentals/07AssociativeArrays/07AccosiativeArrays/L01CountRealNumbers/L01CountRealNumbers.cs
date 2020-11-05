using System;
using System.Collections.Generic;
using System.Linq;

namespace L01CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            var inputListOfNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var sortedList = new SortedDictionary<double, int>();

            foreach (var number in inputListOfNumbers)
            {
                if (!sortedList.ContainsKey(number))
                {
                    sortedList.Add(number, 0);
                }

                sortedList[number]++;
            }

            foreach (var number in sortedList)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
