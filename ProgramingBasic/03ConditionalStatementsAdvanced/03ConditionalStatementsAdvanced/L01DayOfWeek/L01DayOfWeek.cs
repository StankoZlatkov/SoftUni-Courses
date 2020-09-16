using System;

namespace L01DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            byte dayNumber = byte.Parse(Console.ReadLine());
            string dayName = string.Empty;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";;
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Error";
                    break;
            }

            Console.WriteLine(dayName);
        }
    }
}
