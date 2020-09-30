using System;

namespace M01SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int max = Math.Max(Math.Max(n1, n2), n3);
            int min = Math.Min(Math.Min(n1, n2), n3);
            int mdl = (n1 + n2 + n3) - (max + min);

            Console.WriteLine(max);
            Console.WriteLine(mdl);
            Console.WriteLine(min);
        }
    }
}
