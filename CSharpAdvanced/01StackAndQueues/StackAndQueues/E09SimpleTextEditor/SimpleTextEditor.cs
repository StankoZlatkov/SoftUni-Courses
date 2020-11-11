namespace E09SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SimpleTextEditor
    {
        static void Main()
        {
            string text = string.Empty;
            Stack<string> temp = new Stack<string>();
            temp.Push(text);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries )
                    .ToArray();

                if (command[0] == "1")
                {
                    text += command[1];
                    temp.Push(text);
                }
                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);
                    text = text.Substring(0, text.Length - count);
                    temp.Push(text);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command[0] == "4")
                {
                    temp.Pop();
                    text = temp.First();
                }
            }
        }
    }
}
