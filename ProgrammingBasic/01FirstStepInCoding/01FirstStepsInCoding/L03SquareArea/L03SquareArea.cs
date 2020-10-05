namespace L03SquareArea
{
    using System;

    class SquareArea
    {
        static void Main()
        {
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = (Math.Pow(squareSide, 2));

            Console.WriteLine(squareArea);
        }
    }
}
