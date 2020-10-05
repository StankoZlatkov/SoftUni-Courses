using System;

namespace E01Cinema
{
    class Cinema
    {
        static void Main()
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;

            if (movieType == "Premiere")
            {
                double profit = seats * 12.00;
                Console.WriteLine("{0:F2} leva", profit);
            }
            else if (movieType == "Normal")
            {
                double profit = seats * 7.50;
                Console.WriteLine("{0:F2} leva", profit);
            }
            else if (movieType == "Discount")
            {
                double profit = seats * 5.00;
                Console.WriteLine("{0:F2} leva", profit);
            }
        }
    }
}
