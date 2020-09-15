namespace L06AreaOfFigures
{
    using System;

    class AreaOfFigures
    {
        static void Main()
        {
            string inputFigure = Console.ReadLine();
            double figureArea = 0;

            if (inputFigure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                figureArea = squareSide * squareSide;
            }
            else if (inputFigure == "rectangle")
            {
                double rectangleFirstSide = double.Parse(Console.ReadLine());
                double rectangleSecondSide = double.Parse(Console.ReadLine());
                figureArea = rectangleFirstSide * rectangleSecondSide;
            }
            else if (inputFigure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHight = double.Parse(Console.ReadLine());
                figureArea = (triangleSide * triangleHight) / 2;
            }
            else if (inputFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                figureArea = Math.PI * radius * radius; 
            }

            Console.WriteLine(figureArea);
        }
    }
}
