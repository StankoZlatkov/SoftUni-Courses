using System;

namespace M05Messages
{
    class Messages
    {
        static void Main()
        {
            int numberOfSymbols = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 1; i <= numberOfSymbols; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    output = output + " ";
                    continue;
                }

                int digitLength = -1;
                int inputLength = input;

                do
                {
                    inputLength = inputLength / 10;
                    digitLength++;
                } while (inputLength != 0);

                int mainDigit = (input % 10);
                int offset;

                if (mainDigit <= 7)
                {
                    offset = (mainDigit - 2) * 3 + digitLength + 97;
                }
                else
                {
                    offset = (mainDigit - 2) * 3 + digitLength + 1 + 97;
                }
                output = output + (char)offset;
            }
            Console.WriteLine(output);
        }
    }
}
