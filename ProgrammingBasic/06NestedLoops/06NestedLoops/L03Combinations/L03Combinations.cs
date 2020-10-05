using System;

namespace L03Combinations
{
    class Combinations
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (int n1 = 0; n1 <= number; n1++)
            {
                for (int n2 = 0; n2 <= number; n2++)
                {
                    for (int n3 = 0; n3 <= number; n3++)
                    {
                        if (n1 +n2 +n3 == number)
                        {
                            combinations++;
                        }
                    }
                }
            }

            Console.WriteLine(combinations);
        }
    }
}
