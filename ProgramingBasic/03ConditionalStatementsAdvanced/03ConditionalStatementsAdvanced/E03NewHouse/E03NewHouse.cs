using System;

namespace E03NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            string flowers = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            int budged = int.Parse(Console.ReadLine());


            double flowerPrice = 0;

            if (flowers == "Roses")
            {
                if (qty > 80)
                {
                    flowerPrice = (qty * 5.0) * 0.90;
                }
                else
                {
                    flowerPrice = qty * 5.0;
                }
            }

            else if (flowers == "Dahlias")
            {
                if (qty > 90)
                {
                    flowerPrice = (qty * 3.80) * 0.85;
                }
                else
                {
                    flowerPrice = qty * 3.80;
                }
            }

            else if (flowers == "Tulips")
            {
                if (qty > 80)
                {
                    flowerPrice = (qty * 2.80) * 0.85;
                }
                else
                {
                    flowerPrice = (qty * 2.80);
                }
            }

            else if (flowers == "Narcissus")
            {
                if (qty < 120)
                {
                    flowerPrice = (qty * 3) * 1.15;
                }
                else
                {
                    flowerPrice = (qty * 3);
                }
            }

            else if (flowers == "Gladiolus")
            {
                if (qty < 80)
                {
                    flowerPrice = (qty * 2.50) * 1.20;
                }
                else
                {
                    flowerPrice = qty * 2.50;
                }
            }

            if (budged >= flowerPrice)
            {
                double money = budged - flowerPrice;
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", qty, flowers, money);
            }
            else
            {
                double money = flowerPrice - budged;
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", money);
            }
        }
    }
}
