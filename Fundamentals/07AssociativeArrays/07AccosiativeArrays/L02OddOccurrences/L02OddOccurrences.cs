using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace L02OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var inputListOfStrings = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var countList = new Dictionary<string, int>();

            foreach (var word in inputListOfStrings)
            {
                if (!countList.ContainsKey(word))
                {
                    countList.Add(word, 0);
                }

                countList[word]++;
            }

            foreach (var word in countList)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
