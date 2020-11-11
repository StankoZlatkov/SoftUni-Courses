namespace L05PrintEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PrintEvenNumbers
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> list = new Queue<int>(input);
            List<int> toPrint = new List<int>();

            while (list.Count > 0)
            {
                int even = list.Dequeue();

                if (even % 2 == 0)
                {
                    toPrint.Add(even);
                }
            }
            Console.WriteLine(string.Join(", ", toPrint));
        }
    }
}
