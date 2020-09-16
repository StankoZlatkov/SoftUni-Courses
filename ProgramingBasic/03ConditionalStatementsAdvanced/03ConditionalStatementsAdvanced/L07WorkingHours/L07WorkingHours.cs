using System;

namespace L07WorkingHours
{
    class WorkingHours
    {
        static void Main()
        {
            sbyte hour = sbyte.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            string officeStaus = string.Empty;

            bool workingHour = false;
            bool workingDay = false;

            if (hour >= 10 && hour <= 18 )
            {
                workingHour = true;
            }

            if (dayOfWeek != "Sunday")
            {
                workingDay = true;
            }

            if (workingDay && workingHour)
            {
                officeStaus = "open";
            }
            else
            {
                officeStaus = "closed";
            }

            Console.WriteLine(officeStaus);
        }
    }
}
