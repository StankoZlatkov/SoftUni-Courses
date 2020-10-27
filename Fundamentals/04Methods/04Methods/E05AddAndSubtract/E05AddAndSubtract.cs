using System;

namespace E05AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thirtd = int.Parse(Console.ReadLine());

            int sum = GetSum(first, second);
            int diff = GetDifference(sum, thirtd);

            Console.WriteLine(diff);
        }
        public static int GetSum(int a, int b)
        {
            return a + b;

        }
        public static int GetDifference(int a, int b)
        {
            return a - b;
        }
    }
}
