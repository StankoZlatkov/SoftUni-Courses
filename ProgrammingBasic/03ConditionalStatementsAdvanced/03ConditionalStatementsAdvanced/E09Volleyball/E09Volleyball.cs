using System;

namespace E09Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double gamesSofia = (48 - weekends) * (3.0 / 4.0);
            double gamesHolydays = holydays * (2.0 / 3.0);
            double gamesPerNormalYear = Math.Truncate(gamesSofia + weekends + gamesHolydays);
            double gamesPerLeapYear = Math.Truncate((gamesSofia + weekends + gamesHolydays) * 1.15);

            if (year == "leap")
            {
                Console.WriteLine(gamesPerLeapYear);
            }
            else if (year == "normal")
            {
                Console.WriteLine(gamesPerNormalYear);
            }
        }
    }
}
