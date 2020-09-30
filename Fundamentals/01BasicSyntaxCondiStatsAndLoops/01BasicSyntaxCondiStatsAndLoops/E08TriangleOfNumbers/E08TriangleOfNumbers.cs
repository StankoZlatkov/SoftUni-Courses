using System;

namespace E08TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main()
        {
            {
                int n = int.Parse(Console.ReadLine());

                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write($"{row} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
