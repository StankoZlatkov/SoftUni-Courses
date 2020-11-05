using System;
using System.Linq;

namespace L05WordFilter
{
    class WordFilter
    {
        static void Main()
        {
            var inputList = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Where(x => x.Length % 2 == 0)
               .ToArray();

            foreach (var word in inputList)
            {
                Console.WriteLine(word);
            }

        }
    }
}
