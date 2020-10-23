using System;

namespace L01SignOfIntegerNumbers
{
    class SignOfIntegerNumbers
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            PrintNumberSign(inputNumber);
        }

        public static void PrintNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
