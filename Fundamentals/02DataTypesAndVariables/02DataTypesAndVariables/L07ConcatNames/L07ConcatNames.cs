using System;

namespace L07ConcatNames
{
    class ConcatNames
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimer = Console.ReadLine();

            Console.WriteLine(firstName + delimer + secondName);
        }
    }
}
