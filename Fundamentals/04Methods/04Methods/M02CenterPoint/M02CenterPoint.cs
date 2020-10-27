using System;

namespace M02CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloseToTheCeneterPoint(x1, y1, x2, y2);
        }

        public static void PrintCloseToTheCeneterPoint(double x1, double y1, double x2, double y2)
        {
            double firstPointCoordinates = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondPointCoordinates = Math.Pow(x2, 2) + Math.Pow(y2, 2);

            if (firstPointCoordinates <= secondPointCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
