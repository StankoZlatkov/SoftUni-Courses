using System;

namespace L04Sequence2kPlus1
{
    class Sequence2kPlus1
    {
        static void Main()
        {
            int lastNumber = int.Parse(Console.ReadLine());
            int firstNumber = 1;

            while (firstNumber <= lastNumber)
            {
                Console.WriteLine(firstNumber);
                firstNumber = (2 * firstNumber) + 1;
            }
        }
    }
}
