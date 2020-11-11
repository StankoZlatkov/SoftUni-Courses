namespace L02StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StackSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> list = new Stack<int>(input);

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] array = command.Split().ToArray();

                if (command == "end")
                {
                    break;
                }
                else if (array[0] == "add")
                {
                    list.Push(int.Parse(array[1]));
                    list.Push(int.Parse(array[2]));
                }
                else if (array[0] == "remove")
                {
                    int remove = int.Parse(array[1]);

                    if (remove <= list.Count)
                    {
                        for (int i = 0; i < remove; i++)
                        {
                            list.Pop();
                        }
                    }
                }
            }
            Console.WriteLine("Sum: " + list.Sum());
        }
    }
}
