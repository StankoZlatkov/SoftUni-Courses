using System;

namespace E01SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            GetSamallestNumber(first, second, third);

        }

        public static void GetSamallestNumber(double a, double b, double c)
        {
            Console.WriteLine(Math.Min(Math.Min(a, b), c));
        }
    }
}
