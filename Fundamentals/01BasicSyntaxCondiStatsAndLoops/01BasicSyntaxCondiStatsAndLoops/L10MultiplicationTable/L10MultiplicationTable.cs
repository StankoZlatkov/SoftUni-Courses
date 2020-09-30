using System;

namespace L10MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{inputNumber} X {i} = {inputNumber * i}");
            }
        }
    }
}
