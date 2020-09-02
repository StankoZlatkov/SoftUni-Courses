namespace E02RadiansToDegrees
{
    using System;

    class RadiansToDegrees
    {
        static void Main()
        {
            double angleRadians = double.Parse(Console.ReadLine());
            double angleDegrees = angleRadians * (180 / Math.PI);

            Console.WriteLine(Math.Round(angleDegrees));
        }
    }
}
