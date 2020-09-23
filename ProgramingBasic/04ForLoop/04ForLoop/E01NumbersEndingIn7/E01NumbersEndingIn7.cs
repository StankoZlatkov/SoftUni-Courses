using System;

namespace E01NumbersEndingIn7
{
    class NumbersEndingIn7
    {
        static void Main()
        {
            for (int num = 1; num <= 1000; num++)
            {
                if (num % 10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
