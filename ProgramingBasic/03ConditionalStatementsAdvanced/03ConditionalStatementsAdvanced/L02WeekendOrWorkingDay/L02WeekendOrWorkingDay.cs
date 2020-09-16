using System;

namespace L02WeekendOrWorkingDay
{
    class WeekendOrWorkingDay
    {
        static void Main()
        {
            string dayName = Console.ReadLine();

            switch (dayName)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
