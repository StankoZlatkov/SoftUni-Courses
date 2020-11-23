using System;
using System.Collections.Generic;

namespace L05PathsInLabyrinth
{
    class PathsInLabyrinth
    {
        static List<char> findedPaths = new List<char>();
        static char start = 'S';
        static char visited = 'V';
        static char wall = '*';
        static char path = '-';
        static char exit = 'e';
        static char up = 'U';
        static char down = 'D';
        static char left = 'L';
        static char right = 'R';

        static void Main()
        {
            int labyrinthRows = int.Parse(Console.ReadLine());
            int labyrinthCols = int.Parse(Console.ReadLine());

            char[,] labyrinth = new char[labyrinthRows, labyrinthCols];

            BuildLabyrinth(labyrinth, labyrinthRows, labyrinthCols);
            FindPaths(labyrinth, 0, 0, start);
        }

        private static void FindPaths(char[,] labyrinth, int row, int col, char direction)
        {
            if (!IsInLabyrinth(labyrinth, row, col))
            {
                return;
            }

            findedPaths.Add(direction);

            if (IsExit(labyrinth, row, col))
            {
                PrintPath();
            }
            else if (IsPath(labyrinth, row, col) && !IsVisited(labyrinth, row, col))
            {
                Visit(labyrinth, row, col);
                FindPaths(labyrinth, row, col - 1, left);
                FindPaths(labyrinth, row, col + 1, right);
                FindPaths(labyrinth, row - 1, col, up);
                FindPaths(labyrinth, row + 1, col, down);
                Back(labyrinth, row, col);
            }

            findedPaths.RemoveAt(findedPaths.Count - 1);
        }

        private static void PrintPath()
        {
            int startFrom = findedPaths.IndexOf(start);
            for (int i = 1; i < findedPaths.Count; i++)
            {
                Console.Write(findedPaths[i]);
            }
            Console.WriteLine();
        }

        private static void Back(char[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = path;
        }

        private static void Visit(char[,] labyrinth, int row, int col)
        {
            labyrinth[row, col] = visited;
        }

        private static bool IsVisited(char[,] labyrinth, int row, int col)
        {
            if (labyrinth[row, col] == visited)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPath(char[,] labyrinth, int row, int col)
        {
            if (labyrinth[row, col] == wall)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsExit(char[,] labyrinth, int row, int col)
        {
            if (labyrinth[row, col] == exit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsInLabyrinth(char[,] labyrinth, int row, int col)
        {
            if (row < 0 
                || col < 0 
                || row >= labyrinth.GetLength(0)
                || col >= labyrinth.GetLength(1)) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void BuildLabyrinth(char[,] labyrinth, int labyrinthRows, int labyrinthCols)
        {
            for (int rows = 0; rows < labyrinthRows; rows++)
            {
                char[] inpurRow = Console.ReadLine().ToCharArray();
                for (int cols = 0; cols < labyrinthCols; cols++)
                {
                    labyrinth[rows, cols] = inpurRow[cols];
                }
            }
        }
    }
}