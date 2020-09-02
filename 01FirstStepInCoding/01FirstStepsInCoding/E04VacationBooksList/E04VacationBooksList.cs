namespace E04VacationBooksList
{
    using System;

    class VacationBooksList
    {
        static void Main()
        {
            int bookPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hoursPerDay = (bookPages / pagesPerHour) / days;

            Console.WriteLine($"{hoursPerDay}");
        }
    }
}
