namespace L06Supermarket
{
    using System;
    using System.Collections.Generic;

    class Supermarket
    {
        static void Main()
        {
            Queue<string> list = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    while (list.Count > 0)
                    {
                        string name = list.Dequeue();
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    list.Enqueue(input);
                }
            }
            Console.WriteLine(list.Count + " people remaining.");
        }
    }
}
