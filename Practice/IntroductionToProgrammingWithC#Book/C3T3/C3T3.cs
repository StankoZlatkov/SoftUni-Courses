using System;

namespace C3T3
{
    class C3T3
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            inputNumber /= 100;

            Console.WriteLine(inputNumber % 10 == 7 ? "is seven" : "is not seven");
        }
    }
}
