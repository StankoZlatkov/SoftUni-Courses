using System;

namespace E06Cake
{
    class Cake
    {
        static void Main()
        {
            int cakeLendth = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());

            int cakePeices = cakeLendth * cakeWidth;
            int remainingPieces = cakePeices;

            while (remainingPieces > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP") break;

                int takenPieces = int.Parse(input);
                remainingPieces = remainingPieces - takenPieces;
            }

            if (remainingPieces > 0)
            {
                Console.WriteLine($"{remainingPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(remainingPieces)} pieces more.");
            }
        }
    }
}
