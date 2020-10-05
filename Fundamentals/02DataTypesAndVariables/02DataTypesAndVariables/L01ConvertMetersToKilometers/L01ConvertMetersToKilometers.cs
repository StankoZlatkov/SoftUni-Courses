using System;

namespace L01ConvertMetersToKilometers
{
    class ConvertMetersToKilometers
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0m;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
