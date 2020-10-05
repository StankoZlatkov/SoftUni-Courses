using System;

namespace E04SumOfChars
{
    class SumOfChars
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int line = 1; line <= lines; line++)
            {
                char input = char.Parse(Console.ReadLine());

                sum += (int)input;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
