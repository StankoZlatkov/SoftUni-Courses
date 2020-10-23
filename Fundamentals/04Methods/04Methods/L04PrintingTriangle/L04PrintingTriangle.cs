using System;

namespace L04PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int triangleSize = int.Parse(Console.ReadLine());

            PrintingTopHalfOfTriangle(triangleSize);
            PrintingBottomHalfOfTriangle(triangleSize - 1);
        }

        public static void PrintingTopHalfOfTriangle(int topRows)
        {
            for (int row = 1; row <= topRows; row++)
            {
                PrintColumns(row);
                Console.WriteLine();
            }
        }

        public static void PrintingBottomHalfOfTriangle(int bottomRows)
        {
            for (int row = bottomRows; row >= 1; row--)
            {
                PrintColumns(row);
                Console.WriteLine();
            }
        }

        private static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
        }
    }
}
