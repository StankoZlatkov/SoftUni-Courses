using System;

namespace E01NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            int currentNumber = 1;

            for (int row = 1; row <= numbers; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (currentNumber > numbers)
                    {
                        break;
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                if (currentNumber > numbers)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
