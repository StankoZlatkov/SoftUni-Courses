using System;

namespace M01EncryptSortAndPrintArray
{
    class EncryptSortAndPrintArray
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int[] output = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                char[] arrayLetters = input.ToCharArray();

                int charValue = 0;
                int sum = 0;
                foreach (char letter in arrayLetters)
                {
                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            charValue = (int)letter * arrayLetters.Length;
                            break;
                        default:
                            charValue = (int)letter / arrayLetters.Length;
                            break;
                    }
                    sum += charValue;
                }
                output[i] = sum;
            }

            Array.Sort(output);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
