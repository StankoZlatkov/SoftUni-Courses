using System;

namespace L11MultiplicationTablev2
{
    class MultiplicationTablev2
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n2 > 10)
            {
                Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
            }
            else
            {
                for (int i = n2; i <= 10; i++)
                {
                    Console.WriteLine($"{n1} X {i} = {n1 * i}");
                }
            }
        }
    }
}
