using System;

namespace L11CleverLily
{
    class CleverLily
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washmashinPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int evenAge = 0;

            double evenAgeSum = 0;
            double oddAgeToys = 0;
            int first = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenAgeSum += first * 10;
                    evenAge++;
                    first++;
                }
                else
                {
                    oddAgeToys++;
                }
            }
            double sum = evenAgeSum - evenAge + oddAgeToys * toyPrice;

            if (sum >= washmashinPrice)
            {
                double diff = sum - washmashinPrice;
                Console.WriteLine("Yes! {0:F2}", diff);
            }
            else
            {
                double diff = washmashinPrice - sum;
                Console.WriteLine("No! {0:F2}", diff);
            }
        }
    }
}
