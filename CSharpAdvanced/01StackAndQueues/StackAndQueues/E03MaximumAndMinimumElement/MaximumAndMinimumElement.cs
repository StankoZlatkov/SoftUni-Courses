namespace E03MaximumAndMinimumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximumAndMinimumElement
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Stack<int> list = new Stack<int>();

            for (int i = 0; i < lines; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = command[0];

                if (action == 1)
                {
                    int number = command[1];
                    list.Push(number);
                }
                else if (action == 2)
                {
                    list.Pop();
                }
                else if (action == 3)
                {
                    int max = int.MinValue;

                    foreach (var num in list)
                    {
                        if (num > max)
                        {
                            max = num;
                            Console.WriteLine(max);
                        }
                    }
                }
                else if (action == 4)
                {
                    int min = int.MaxValue;

                    foreach (var num in list)
                    {
                        if (num < min)
                        {
                            min = num;
                            Console.WriteLine(min);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}