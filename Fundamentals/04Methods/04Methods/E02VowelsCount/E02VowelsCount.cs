using System;

namespace E02VowelsCount
{
    class VowelsCount
    {
        static void Main()
        {
            string input = Console.ReadLine();
            GetVowels(input);
        }

        public static void GetVowels(string text)
        {
            int count = 0;
            char[] arrayChar = text.ToLower().ToCharArray();

            foreach (var letter in arrayChar)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}