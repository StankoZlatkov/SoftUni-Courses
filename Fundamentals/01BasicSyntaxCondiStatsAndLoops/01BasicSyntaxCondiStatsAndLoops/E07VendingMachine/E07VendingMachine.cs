using System;

namespace E07VendingMachine
{
    class VendingMachine
    {
        static void Main()
        {
            double sum = 0;
            while (true)
            {
                var inputCoinsOrStart = Console.ReadLine();

                if (inputCoinsOrStart == "Start")
                {
                    break;
                }

                double coin = double.Parse(inputCoinsOrStart);

                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }

                sum += coin;
            }

            while (true)
            {
                string purchase = Console.ReadLine();

                if (purchase == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                    break;
                }

                double price = 0;

                switch (purchase)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                }

                if (purchase != "Nuts" && purchase != "Water" && purchase != "Crisps" && purchase != "Soda" && purchase != "Coke")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (sum - price >= 0)
                {
                    Console.WriteLine($"Purchased {purchase.ToLower()}");
                    sum -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}

