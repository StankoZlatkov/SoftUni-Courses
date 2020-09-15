using System;

namespace L03EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}