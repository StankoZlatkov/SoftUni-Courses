using System;

namespace E06TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main()
        {
            int letters = int.Parse(Console.ReadLine());

            for (int i = 97; i < letters + 97; i++)
            {
                for (int j = 97; j < letters + 97; j++)
                {
                    for (int k = 97; k < letters + 97; k++)
                    {
                        Console.Write((char)i);
                        Console.Write((char)j);
                        Console.WriteLine((char)k);
                    }
                }
            }
        }
    }
}
