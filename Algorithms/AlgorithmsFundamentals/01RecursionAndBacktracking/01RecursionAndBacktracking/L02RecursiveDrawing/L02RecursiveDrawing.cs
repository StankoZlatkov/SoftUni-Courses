﻿using System;

namespace L02RecursiveDrawing
{
    class RecursiveDrawing
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            PrintFigure(lines);
        }

        private static void PrintFigure(int lines)
        {
            if (lines == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', lines));

            PrintFigure(lines - 1);

            Console.WriteLine(new string('#', lines));
        }
    }
}
