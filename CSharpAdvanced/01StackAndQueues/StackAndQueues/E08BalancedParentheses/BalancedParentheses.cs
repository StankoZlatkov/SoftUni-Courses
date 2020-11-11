namespace E08BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BalancedParentheses
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> list = new List<char>(input);
            bool balanced = true;

            while (list.Count > 1)
            {
                if ((list.First() == '(' && list.Last() == ')') || (list.First() == '[' && list.Last() == ']') || (list.First() == '{' && list.Last() == '}') || (list.First() == ' ' && list.Last() == ' '))
                {
                    list.Remove(list.Last());
                    list.Remove(list.First());
                }
                else
                {
                    balanced = false;
                    break;
                }
            }
            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
