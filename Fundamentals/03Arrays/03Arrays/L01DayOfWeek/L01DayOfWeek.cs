using System;

namespace L01DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] daysOfWeek = {"Monday", 
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"};

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
