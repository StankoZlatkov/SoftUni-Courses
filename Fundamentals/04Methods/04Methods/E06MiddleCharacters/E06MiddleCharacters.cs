using System;

namespace E06MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] inputToArray = input.ToCharArray();

            GetMiddlleChar(inputToArray);

        }
        public static void GetMiddlleChar(char[] array)
        {
            string middleChar = string.Empty;

            if (array.Length % 2 != 0)
            {
                middleChar += array[(array.Length / 2)];
            }
            else
            {
                middleChar += array[(array.Length / 2) - 1];
                middleChar += array[(array.Length / 2)];
            }
            Console.WriteLine(middleChar); ;
        }
    }
}
