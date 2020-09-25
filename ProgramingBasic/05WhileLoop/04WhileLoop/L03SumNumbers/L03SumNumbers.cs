using System;

namespace L03SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < number)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
