using System;

namespace L05CharacterSequence
{
    class CharacterSequence
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                Console.WriteLine(symbol);
            }

        }
    }
}
