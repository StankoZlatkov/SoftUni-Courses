using System;

namespace L02PoundsToDollars
{
    class PoundsToDollars
    {
        static void Main()
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{pounds * 1.31m:f3}");
        }
    }
}
