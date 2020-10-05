using System;

namespace L08CinemaTicket
{
    class CinemaTicket
    {
        static void Main()
        {
            string dayOfWeek = Console.ReadLine();
            int cinemaTicketPrice = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    cinemaTicketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    cinemaTicketPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    cinemaTicketPrice = 16;
                    break;
            }

            Console.WriteLine(cinemaTicketPrice);
        }
    }
}
