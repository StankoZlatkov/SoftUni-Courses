using System;

namespace L02NumbersNTo1
{
    class NumbersNTo1
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = inputNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
