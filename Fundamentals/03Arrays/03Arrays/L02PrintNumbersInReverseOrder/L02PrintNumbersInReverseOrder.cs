using System;

namespace L02PrintNumbersInReverseOrder
{
    class PrintNumbersInReverseOrder
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int[] numbers = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
