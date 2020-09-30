using System;

namespace E06StrongNumber
{
    class StrongNumber
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            int numberOutput = numberInput;
            int sum = 0;

            while (numberInput != 0)
            {
                int residue = 0;
                int fact = 1;
                residue = numberInput % 10;
                numberInput = numberInput / 10;

                for (int i = 2; i <= residue; i++)
                {
                    fact *= i;
                }
                sum += fact;
            }
            if (sum == numberOutput)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
