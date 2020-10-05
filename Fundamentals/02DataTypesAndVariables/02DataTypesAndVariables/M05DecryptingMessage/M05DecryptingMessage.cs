using System;

namespace M05DecryptingMessage
{
    class DecryptingMessage
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                input += (char)key;
                output += (input);
            }
            Console.WriteLine(output);
        }
    }
}
