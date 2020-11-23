using System;
using System.Collections.Generic;

namespace L06EightQueensPuzzle
{
    class EightQueensPuzzle
    {
        static int input = 8;
        static int rows = input;
        static int cols = input;
        static int queens = input;
        static int queensOnBoard = 0;
        static char queen = '*';
        static char freeField = '-';
        static char[,] board = new char[rows, cols];
        static HashSet<int> attckedHorizontal = new HashSet<int>();
        static HashSet<int> attckedVertical = new HashSet<int>();
        static HashSet<int> attckedLeftDiagonal = new HashSet<int>();
        static HashSet<int> attckedRightDiagonal = new HashSet<int>();

        static void Main()
        {
            CreateBoard(rows, cols);
            PlaceQueens(0);
        }

        private static void CreateBoard(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

        private static void PlaceQueens(int row)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (queensOnBoard == queens)
                {
                    PrintBoard();
                    return;
                }
                if (IsOutOfBoard(row, col))
                {
                    return;
                }
                if (!IsAttack(row, col))
                {
                    AddQueen(row, col);
                    attckedHorizontal.Add(row);
                    attckedVertical.Add(col);
                    attckedLeftDiagonal.Add(col - row);
                    attckedRightDiagonal.Add(col + row);

                    PlaceQueens(row + 1);

                    RemoveQueen(row, col);
                    attckedHorizontal.Remove(row);
                    attckedVertical.Remove(col);
                    attckedLeftDiagonal.Remove(col - row);
                    attckedRightDiagonal.Remove(col + row);
                }
            }
          
        }

        private static void PrintBoard()
        {
            for (int rows = 0; rows < board.GetLength(0); rows++)
            {
                for (int cols = 0; cols < board.GetLength(1); cols++)
                {
                    Console.Write($"{board[rows, cols]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void AddQueen(int row, int col)
        {
            board[row, col] = queen;
            queensOnBoard++;
        }

        private static void RemoveQueen(int row, int col)
        {
            board[row, col] = freeField;
            queensOnBoard--;
        }

        private static bool IsAttack(int row, int col)
        {
            if (AttackHorizontal(row) || AttackVertical(col) || AttackLeftDiagonal(row, col) || AttackRightDiagonal(row, col))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool AttackHorizontal(int row)
        {
            if (attckedHorizontal.Contains(row))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool AttackVertical(int col)
        {
            if (attckedVertical.Contains(col))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool AttackLeftDiagonal(int row, int col)
        {
            int leftDiagonal = col - row;

            if (attckedLeftDiagonal.Contains(leftDiagonal))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool AttackRightDiagonal(int row, int col)
        {
            int rightDiagonal = col + row;

            if (attckedRightDiagonal.Contains(rightDiagonal))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsOutOfBoard(int row, int col)
        {
            if (row < 0
                || col < 0
                || row >= board.GetLength(0)
                || col >= board.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}