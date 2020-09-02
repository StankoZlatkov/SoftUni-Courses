namespace E01USDToBGN
{
    using System;

    class USDToBGN
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double exchangeRate = 1.79549;

            double bgn = usd * exchangeRate;

            Console.WriteLine($"{bgn:f2}");
        }
    }
}
