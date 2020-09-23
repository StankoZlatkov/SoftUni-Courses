using System;

namespace L07SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;

            }

            Console.WriteLine(sum);
        }
    }
}
