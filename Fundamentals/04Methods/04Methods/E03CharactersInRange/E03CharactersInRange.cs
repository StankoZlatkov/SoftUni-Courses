using System;

namespace E03CharactersInRange
{
    class CharactersInRange
    {
        static void Main()
        {
            char fromChar = char.Parse(Console.ReadLine());
            char toChar = char.Parse(Console.ReadLine());

            PrintCharsInRange(fromChar, toChar);
        }

        static void PrintCharsInRange(char first, char last)
        {
            string output = string.Empty;
            int max = Math.Max((int)first, (int)last);
            int min = Math.Min((int)first, (int)last);

            for (int i = ++min; i < max; i++)
            {
                output += (char)i + " ";
            }
            Console.WriteLine(output);
        }
    }
}
