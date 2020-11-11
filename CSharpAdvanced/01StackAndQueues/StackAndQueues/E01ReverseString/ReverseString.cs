using System;
using System.Collections.Generic;

namespace L01ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var reverse = new Stack<char>();

            foreach (var @char in input)
            {
                reverse.Push(@char);
            }
            Console.WriteLine(string.Join(string.Empty, reverse));
        }
    }
}
