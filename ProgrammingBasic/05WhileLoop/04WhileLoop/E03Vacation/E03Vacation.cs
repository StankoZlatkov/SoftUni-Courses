using System;

namespace E03Vacation
{
    class Vacation
    {
        static void Main()
        {
            decimal moneyForTrip = decimal.Parse(Console.ReadLine());
            decimal availableMoney = decimal.Parse(Console.ReadLine());

            decimal totalMoney = availableMoney;
            int daysWhenSpend = 0;
            int totalDays = 0;

            while (true)
            {
                if (totalMoney >= moneyForTrip)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    break;
                }
                string command = Console.ReadLine();
                decimal moneyCommand = decimal.Parse(Console.ReadLine());

                totalDays++;

                if (command == "save")
                {
                    totalMoney += moneyCommand;
                    daysWhenSpend = 0;
                }

                if (command == "spend")
                {
                    if (moneyCommand >= availableMoney)
                    {
                       totalMoney = 0;
                    }
                    else
                    {
                        totalMoney -= moneyCommand;
                    }

                    daysWhenSpend++;
                    if (daysWhenSpend >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        break;
                    }
                }
            }
        }
    }
}
