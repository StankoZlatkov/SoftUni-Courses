using System;

namespace L03ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < lines; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
