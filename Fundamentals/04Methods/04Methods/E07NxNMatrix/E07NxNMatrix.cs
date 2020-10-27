using System;

namespace E07NxNMatrix
{
    class E07NxNMatrix
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            PrintSquare(lines);

        }
        public static void PrintSquare(int lines)
        {
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= lines; j++)
                {
                    Console.Write(lines + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
