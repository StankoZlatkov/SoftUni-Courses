using System;

namespace E10RageExpenses
{
    class RageExpenses
    {
        static void Main()
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            float headestPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float dispalyPrice = float.Parse(Console.ReadLine());

            int headestCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int keyboardCount2 = 0;
            int dispalyCount = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headestCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    keyboardCount2++;
                }

                if (keyboardCount2 == 2)
                {
                    dispalyCount++;
                    keyboardCount2 = 0;
                }
            }

            double sum = (headestCount * headestPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice) + (dispalyCount * dispalyPrice);
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
