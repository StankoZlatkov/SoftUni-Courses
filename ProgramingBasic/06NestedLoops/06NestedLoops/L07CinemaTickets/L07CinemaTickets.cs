using System;

namespace L07CinemaTickets
{
    class L07CinemaTickets
    {
        static void Main()
        {
            int studentTicketsTotal = 0;
            int standartTicketsTotal = 0;
            int kidTicketsTotal = 0;

            double totalTickets = 0;
            bool isFinished = false;

            while (true)
            {
                if (isFinished == true)
                {
                    break;
                }
                string filmName = Console.ReadLine();

                int freeSeats = int.Parse(Console.ReadLine());
                int studentTicketsFilm = 0;
                int standartTicketsFilm = 0;
                int kidTicketsFilm = 0;

                if (filmName == "Finish")
                {
                    break;
                }

                while (standartTicketsFilm
                     + studentTicketsFilm
                     + kidTicketsFilm <= freeSeats)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "standard")
                    {
                        standartTicketsFilm++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicketsFilm++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsFilm++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "Finish")
                    {
                        isFinished = true;
                        break;
                    }
                }

                double filmTickets = standartTicketsFilm
                              + studentTicketsFilm
                              +kidTicketsFilm;
                standartTicketsTotal += standartTicketsFilm;
                studentTicketsTotal += studentTicketsFilm;
                kidTicketsTotal += kidTicketsFilm;

                totalTickets += filmTickets;

                double filmPercentTickets = (filmTickets / freeSeats) * 100;
                Console.WriteLine($"{filmName} - {filmPercentTickets:f2}% full.");
            }

            double studentTicketsPercent = (studentTicketsTotal / totalTickets) * 100;
            double standartTicketsPercent = (standartTicketsTotal / totalTickets) * 100;
            double kidTicketsPercent = (kidTicketsTotal / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standartTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
        }
    }
}
