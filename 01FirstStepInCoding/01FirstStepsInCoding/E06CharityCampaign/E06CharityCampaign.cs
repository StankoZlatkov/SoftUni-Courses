namespace E06CharityCampaign
{
    using System;

    class CharityCampaign
    {
        static void Main()
        {
            int campaignPeriod = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45;
            double wafflesPrice = 5.8;
            double pancakePrice = 3.2;

            double expenses = 0.125;

            int totalCakes = cakes * confectioner * campaignPeriod;
            int totalWaffles = waffles * confectioner * campaignPeriod;
            int totalPanakes = pancakes * confectioner * campaignPeriod;

            double totalSum = totalCakes * cakePrice + totalWaffles * wafflesPrice + totalPanakes * pancakePrice;
            double finalSum = totalSum * (1 - expenses);

            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
