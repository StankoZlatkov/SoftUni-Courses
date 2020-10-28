using System;
using System.Collections.Generic;
using System.Linq;

namespace L03MergingLists
{
    class MergingLists
    {
        static void Main()
        {
            var firstInputList = new List<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
            var secondInputList = new List<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
            var mergedList = new List<int>();

            for (int i = 0; i < firstInputList.Count + secondInputList.Count; i++)
            {
                if (i <= firstInputList.Count - 1)
                {
                    mergedList.Add(firstInputList[i]);
                }
                if (i <= secondInputList.Count - 1)
                {
                    mergedList.Add(secondInputList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
