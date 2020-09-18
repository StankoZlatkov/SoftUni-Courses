using System;

namespace C3T1
{
    class C3T1
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine(inputNum % 2 == 0 ? "even" : "odd");
        }
    }
}
