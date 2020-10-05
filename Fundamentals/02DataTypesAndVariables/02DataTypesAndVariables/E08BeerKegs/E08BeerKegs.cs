using System;

namespace E08BeerKegs
{
    class BeerKegs
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string output = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    output = model;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(output);
        }
    }
}
