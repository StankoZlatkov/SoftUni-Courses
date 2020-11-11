namespace L07HotPotato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HotPotato
    {
        static void Main()
        {
            var playersList = new Queue<string>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray());

            int toss = int.Parse(Console.ReadLine());

            while (playersList.Count > 1)
            {
                for (int i = 1; i < toss; i++)
                {
                    playersList.Enqueue(playersList.Dequeue());
                }

                Console.WriteLine($"Removed {playersList.Dequeue()}");
            }

            Console.WriteLine($"Last is {playersList.Peek()}");
        }
    }
}
