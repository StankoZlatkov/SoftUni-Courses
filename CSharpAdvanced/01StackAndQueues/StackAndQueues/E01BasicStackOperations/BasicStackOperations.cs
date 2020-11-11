namespace E01BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicStackOperations
    {
        static void Main()
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> list = new Stack<int>();

            int toPush = commands[0];
            int toPop = commands[1];
            int toCompare = commands[2];

            for (int i = 0; i < toPush; i++)
            {
                list.Push(numbers[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                list.Pop();
            }
            if (list.Contains(toCompare))
            {
                Console.WriteLine("true");
            }
            else if (list.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = int.MaxValue;

                foreach (var num in list)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                Console.WriteLine(min);
            }

        }
    }
}
