using System;

namespace L06CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main()
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHight = double.Parse(Console.ReadLine());

            double rectangleArea = GetRectangleArea(rectangleWidth, rectangleHight);
            Console.WriteLine($"{rectangleArea}");
        }

        public static double GetRectangleArea(double width, double hight)
        {
            double rectangleArea = width * hight;
            return rectangleArea;
        }
    }
}
