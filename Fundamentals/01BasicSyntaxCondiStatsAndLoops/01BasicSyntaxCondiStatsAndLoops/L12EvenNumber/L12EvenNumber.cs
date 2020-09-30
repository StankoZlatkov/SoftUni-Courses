using System;

namespace L12EvenNumber
{
    class EvenNumber
    {
        static void Main()
        {
            while (true)
            {
                int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));
                if (inputNumber % 2 == 0)
                {
                    Console.WriteLine($"The number is: {inputNumber}");
                    break; ;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
