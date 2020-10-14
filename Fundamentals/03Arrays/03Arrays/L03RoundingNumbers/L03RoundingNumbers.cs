using System;
using System.Linq;

namespace L03RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main()
        {
            double[] inputNumbets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var number in inputNumbets)
            {
                int roundNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundNumber}");
            }
        }
    }
}
