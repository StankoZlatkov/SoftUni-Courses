using System;
using System.Collections.Generic;
using System.Linq;

namespace L01SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var inputList = new List<double>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList());

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
