using System;
using System.Text;

namespace L07RepeatString
{
    class RepeatString
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string repeatedText = GetRepeatedString(inputText, repeat);
            Console.WriteLine(repeatedText);
        }

        public static string GetRepeatedString(string inputText, int repeat)
        {
            StringBuilder repeatedString = new StringBuilder();

            for (int i = 1; i <= repeat; i++)
            {
                repeatedString.Append(inputText);
            }

            return repeatedString.ToString();
        }
    }
}
