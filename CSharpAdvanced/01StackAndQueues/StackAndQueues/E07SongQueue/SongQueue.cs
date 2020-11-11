namespace E07SongQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SongQueue
    {
        static void Main()
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Add"))
                {
                    string song = command.Substring(4);

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
