using System;

namespace L05SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                int n = i;

                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
