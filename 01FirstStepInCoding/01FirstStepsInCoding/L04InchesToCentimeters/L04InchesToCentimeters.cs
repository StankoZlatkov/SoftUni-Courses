namespace L04InchesToCentimeters
{
    using System;

    class InchesToCentimeters
    {
        static void Main()
        {
            double centimeters = double.Parse(Console.ReadLine());
            double inches = centimeters * 2.54;

            Console.WriteLine(inches);
        }
    }
}
