using System;
using System.Collections.Generic;
using System.Linq;

namespace E01CountCharsInAString
{
    class CountCharsInAString
    {
        static void Main()
        {
            char[] symbols = Console.ReadLine()
                .Where(x => !Char.IsWhiteSpace(x))
                .ToArray();

            var charsList = new Dictionary<char, int>();

            foreach (var symbol in symbols)
            {
                if (!charsList.ContainsKey(symbol))
                {
                    charsList.Add(symbol, 0);
                }

                charsList[symbol]++;
            }

            foreach (var symbol in charsList)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
