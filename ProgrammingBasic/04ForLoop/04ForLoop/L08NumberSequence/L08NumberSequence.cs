using System;

namespace L08NumberSequence
{
    class NumberSequence
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > maxNumber)
                {
                    maxNumber = input;
                }
                if (input < minNumber)
                {
                    minNumber = input;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
