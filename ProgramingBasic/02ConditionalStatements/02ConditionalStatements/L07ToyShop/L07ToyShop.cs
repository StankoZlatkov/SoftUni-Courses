using System;

namespace L07ToyShop
{
    class ToyShop
    {
        static void Main()
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            double puzzlesPrice = 2.6;
            double speakingDollsPrice = 3;
            double teddyBearsPrice = 4.1;
            double minionsPrice = 8.2;
            double tracksPrice = 2;

            double totalToys = puzzles
                             + speakingDolls
                             + teddyBears
                             + minions
                             + tracks;

            double totalToysPrice = puzzles * puzzlesPrice
                                  + speakingDolls * speakingDollsPrice
                                  + teddyBears * teddyBearsPrice
                                  + minions * minionsPrice
                                  + tracks * tracksPrice;

            double discount = 0.25;
            double forRent = 0.1;

            if (totalToys >= 50)
            {
                totalToysPrice *= 1 - discount;
            }

            double totalMoney = totalToysPrice * (1 - forRent);

            if (totalMoney >= tourPrice)
            {
                double leftMoney = totalMoney - tourPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else if (totalMoney <= tourPrice)
            {
                double needMoney = tourPrice - totalMoney;
                Console.WriteLine($"Not enough money! {needMoney:f2} lv needed.");
            }
        }
    }
}
