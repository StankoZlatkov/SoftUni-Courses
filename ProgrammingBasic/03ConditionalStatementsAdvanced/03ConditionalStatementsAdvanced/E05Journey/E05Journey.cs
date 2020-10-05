using System;

namespace E05Journey
{
    class Journey
    {
        static void Main()
        {
            double budged = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            double percent = 0;

            if (budged <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    place = "Camp";
                    percent = 0.30;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    percent = 0.70;
                }
            }
            else if (budged <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    place = "Camp";
                    percent = 0.40;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    percent = 0.80;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                percent = 0.90;
            }

            double money = budged * percent;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine("{0} - {1:F2}", place, money);
        }
    }
}
