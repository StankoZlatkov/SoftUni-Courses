using System;
using System.Collections.Generic;
using System.Linq;

namespace E04Orders
{
    class Orders
    {
        static void Main()
        {
            var list = new Dictionary<string, List<double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }
                string[] array = input.Split(' ').ToArray();
                string product = array[0];
                double price = Convert.ToDouble(array[1]);
                double qty = Convert.ToDouble(array[2]);

                var priceEach = new List<double> { price, qty };

                if (!list.ContainsKey(array[0]))
                {

                    list.Add(product, priceEach);
                }
                else
                {
                    list[product][0] = price;
                    list[product][1] += qty;
                }
            }
            foreach (var product in list)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
            }
        }
    }
}
