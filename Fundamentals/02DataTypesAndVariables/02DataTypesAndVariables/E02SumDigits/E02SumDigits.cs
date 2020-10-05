using System;

namespace E02SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            //string inputNumber = int.Parse(Console.ReadLine()).ToString();

            //int sum = 0;

            //foreach (var digit in inputNumber)
            //{
            //    sum += int.Parse(digit.ToString());
            //}

            //Console.WriteLine(sum);

            int inputNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (inputNumber != 0)
            {
                int temp = inputNumber % 10;
                sum += temp;
                inputNumber /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
