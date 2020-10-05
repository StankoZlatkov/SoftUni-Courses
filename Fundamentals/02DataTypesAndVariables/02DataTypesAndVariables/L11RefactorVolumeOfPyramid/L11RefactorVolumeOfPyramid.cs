using System;

namespace L11RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main()
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = ((lenght * width) / 3) * height;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
