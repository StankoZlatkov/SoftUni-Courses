using System;

namespace E04FishingBoat
{
    class FishingBoat
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishers = double.Parse(Console.ReadLine());

            double springShipRent = 3000;
            double summerAutumnShipRent = 4200;
            double winterShipRent = 2600;
            double discount1 = 1;
            double discount2 = 1;

            if (fishers <= 6)
            {
                discount1 = 0.90;
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                discount1 = 0.85;
            }
            else
            {
                discount1 = 0.75;
            }

            if (fishers % 2 == 0)
            {
                discount2 = 0.95;
            }

            double realMoney = 0;

            if (season == "Spring")
            {
                realMoney = (springShipRent * discount1) * discount2;
            }
            else if (season == "Summer")
            {
                realMoney = (summerAutumnShipRent * discount1) * discount2;
            }
            else if (season == "Autumn")
            {
                realMoney = summerAutumnShipRent * discount1;
            }
            else if (season == "Winter")
            {
                realMoney = (winterShipRent * discount1) * discount2;
            }

            if (budget >= realMoney)
            {
                double leftMoney = budget - realMoney;
                Console.WriteLine("Yes! You have {0:F2} leva left.", leftMoney);
            }
            else if (budget < realMoney)
            {
                double needMoney = realMoney - budget;
                Console.WriteLine("Not enough money! You need {0:F2} leva.", needMoney);
            }
        }
    }
}
