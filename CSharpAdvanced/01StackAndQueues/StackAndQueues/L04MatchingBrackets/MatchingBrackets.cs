namespace L04MatchingBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MatchingBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = indexes.Pop();
                    string toPrint = input.Substring(start, i - start + 1);
                    Console.WriteLine(toPrint);
                }
            }
        }
    }
}
