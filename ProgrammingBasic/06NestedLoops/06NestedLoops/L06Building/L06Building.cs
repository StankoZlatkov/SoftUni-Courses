using System;

namespace L06Building
{
    class Building
    {
        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string type = string.Empty;

            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f % 2 == 0)
                    {
                        type = "O";
                    }
                    else
                    {
                        type = "A";
                    }
                    if (f == floors)
                    {
                        type = "L";
                    }
                    Console.Write($"{type}{f}{r} ");
                }
                Console.WriteLine();
            }
        }
    }
}
