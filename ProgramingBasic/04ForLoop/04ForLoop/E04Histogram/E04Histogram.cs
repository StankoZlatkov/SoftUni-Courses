using System;

namespace E04Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input < 200)
                {
                    p1++;
                }
                else if (input >= 200 && input < 400)
                {
                    p2++;
                }
                else if (input >= 400 && input < 600)
                {
                    p3++;
                }
                else if (input >= 600 && input < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double p1Percent = (p1 / n) * 100;
            double p2Percent = (p2 / n) * 100;
            double p3Percent = (p3 / n) * 100;
            double p4Percent = (p4 / n) * 100;
            double p5Percent = (p5 / n) * 100;

            Console.WriteLine("{0:F2}%", p1Percent);
            Console.WriteLine("{0:F2}%", p2Percent);
            Console.WriteLine("{0:F2}%", p3Percent);
            Console.WriteLine("{0:F2}%", p4Percent);
            Console.WriteLine("{0:F2}%", p5Percent);
        }
    }
}
