using System;

namespace C3T2
{
    class C3T2
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(inputNumber % 5 ==0 && inputNumber % 7 == 0 ? "true" : "false");
        }
    }
}
