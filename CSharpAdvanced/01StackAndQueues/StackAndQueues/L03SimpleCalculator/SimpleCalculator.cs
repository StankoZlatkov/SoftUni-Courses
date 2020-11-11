namespace L03SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SimpleCalculator
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] reverse = input.Split(' ');

            Stack<string> list = new Stack<string>(reverse.Reverse());
            int result = int.Parse(list.Pop());

            while (list.Count > 0)
            {
                string action = list.Pop();

                if (action == "+")
                {
                    result += int.Parse(list.Pop());
                }
                else if (action == "-")
                {
                    result -= int.Parse(list.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
