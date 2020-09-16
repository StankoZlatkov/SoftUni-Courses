using System;

namespace L05SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * qty);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.80 * qty);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.20 * qty);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * qty);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.60 * qty);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.40 * qty);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * qty);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * qty);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * qty);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.50 * qty);
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * qty);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * qty);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.10 * qty);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * qty);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * qty);
                }
            }
        }
    }
}
