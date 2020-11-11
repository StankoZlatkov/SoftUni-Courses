namespace E04FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FastFood
    {
        static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int biggestOrder = int.MinValue;

            foreach (var order in orders)
            {
                if (order > biggestOrder)
                {
                    biggestOrder = order;
                }
            }

            Console.WriteLine(biggestOrder);

            while (orders.Count > 0 && food - orders.First() >= 0)
            {
                food -= orders.Dequeue();
            }

            if (orders.Count > 0)
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(' ', orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
