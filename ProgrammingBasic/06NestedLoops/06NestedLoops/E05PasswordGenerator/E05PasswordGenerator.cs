using System;

namespace E05PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main()
        {
            byte lastDigit = byte.Parse(Console.ReadLine());
            byte lastChar = byte.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= lastDigit; d1++)
            {
                for (int d2 = 1; d2 <= lastDigit; d2++)
                {
                    for (int l1 = 97; l1 < lastChar + 97; l1++)
                    {
                        for (int l2 = 97; l2 < lastChar + 97; l2++)
                        {
                            for (int d3 = 1; d3 <= lastDigit; d3++)
                            {
                                if (d3 <= d1 || d3 <= d2)
                                {
                                    continue;
                                }
                                Console.Write($"{d1}{d2}{(char)l1}{(char)l2}{d3} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
