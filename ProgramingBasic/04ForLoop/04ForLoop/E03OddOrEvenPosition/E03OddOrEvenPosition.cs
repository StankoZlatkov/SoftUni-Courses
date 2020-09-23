using System;

namespace E03OddOrEvenPosition
{
    class OddOrEvenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenSum = 0;
            double oddSum = 0;
            string no = "No";

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }

                    evenSum += num;
                }
                else
                {
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                    oddSum += num;
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else
            {
                Console.WriteLine("OddMin = " + no + ",");
            }
            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMax=" + no + ",");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else
            {
                Console.WriteLine("EvenMin=" + no + ",");
            }
            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2},");
            }
            else
            {
                Console.WriteLine("EvenMax=" + no + ",");
            }
        }
    }
}
