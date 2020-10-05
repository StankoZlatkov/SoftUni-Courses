namespace E05BirthdayParty
{
    using System;

    class BirthdayParty
    {
        static void Main()
        {
            double rentForHall = double.Parse(Console.ReadLine());

            double cakePrice = rentForHall * 0.2;
            double drinksPrice = cakePrice * 0.55;
            double animatorPrice = rentForHall / 3;

            double totalSum = rentForHall + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(totalSum);
        }
    }
}
