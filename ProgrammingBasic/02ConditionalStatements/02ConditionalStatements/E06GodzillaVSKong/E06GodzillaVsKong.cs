using System;

namespace E06GodzillaVsKong
{
    class GodzillaVsKong
    {
        static void Main()
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int walkons = int.Parse(Console.ReadLine());
            double walkonClothPrice = double.Parse(Console.ReadLine());

            double filmDekorPrice = filmBudget * 0.1;
            double totalClothPrice = walkons * walkonClothPrice;

            if (walkons > 150)
            {
                totalClothPrice *= 0.9;
            }

            double filmCost = totalClothPrice + filmDekorPrice;

            if (filmCost > filmBudget)
            {
                double needMoney = filmCost - filmBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else if (filmCost <= filmBudget)
            {
                double leftMoney = filmBudget - filmCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
        }
    }
}
