using System;

namespace E06SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = false;
                int digit = i;

               for (int j = 1; j <= 4; j++)
                {
                    int temp = digit;
                    digit %= 10;
                    if (digit == 0 || number % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else
                    {
                        isSpecial = true;
                    }

                    digit = temp;
                    digit /= 10;
                }

                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
