namespace E03DepositCalculator
{
    using System;

    class DepositCalculator
    {
        static void Main()
        {
            double depositSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double finalSum = depositSum + period * (((depositSum * interestRate) / 100) / 12);

            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
