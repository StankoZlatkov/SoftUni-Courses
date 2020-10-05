using System;

namespace E07WaterOverflow
{
    class WaterOverflow
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;

                if (sum > capacity)
                {
                    sum -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
