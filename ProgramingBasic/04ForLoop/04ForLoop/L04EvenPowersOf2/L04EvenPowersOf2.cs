using System;

namespace L04EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
