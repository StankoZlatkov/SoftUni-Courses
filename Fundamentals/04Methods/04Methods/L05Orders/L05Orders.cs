using System;

namespace L05Orders
{
    class Orders
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOrder(product, quantity);
        }
        public static void PrintOrder(string product, int quantity)
        {
            float price = 0;
            switch (product)
            {
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4f;
                    break;
                case "coffee":
                    price = 1.5f;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            Console.WriteLine($"{(price * quantity):f2}");
        }
    }
}