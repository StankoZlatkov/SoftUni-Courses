using System;

namespace M03FloatingEquality
{
    class FloatingEquality
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(n1 - n2) < 0.000001;
            Console.WriteLine(isEqual);
        }
    }
}
