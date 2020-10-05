using System;

namespace E02HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }

                sum += num;
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                int diff = Math.Abs(sum - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
