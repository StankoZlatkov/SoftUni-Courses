using System;
using System.Collections.Generic;
using System.Linq;

namespace L02GaussTrick
{
    class GaussTrick
    {
        static void Main()
        {
            var inputList = new List<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            for (int i = 0, j = inputList.Count - 1; i <= (inputList.Count - 1) / 2; i++, j--)
            {
                if (inputList.Count > 1)
                {
                    inputList[i] = inputList[i] + inputList[j];
                    inputList.RemoveAt(j);
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
