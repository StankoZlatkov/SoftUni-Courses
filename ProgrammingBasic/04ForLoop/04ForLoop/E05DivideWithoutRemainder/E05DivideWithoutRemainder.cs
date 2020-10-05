using System;

namespace E05DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;

            for (int i = 1; i <= input; i++)
            {

                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p2++;
                }
                if (num % 3 == 0)
                {
                    p3++;
                }
                if (num % 4 == 0)
                {
                    p4++;
                }
            }

            double p2Percent = (p2 / input) * 100;
            double p3Percent = (p3 / input) * 100;
            double p4Percent = (p4 / input) * 100;

            Console.WriteLine("{0:F2}%", p2Percent);
            Console.WriteLine("{0:F2}%", p3Percent);
            Console.WriteLine("{0:F2}%", p4Percent);
        }
    }
}
