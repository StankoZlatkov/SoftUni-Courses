using System;

namespace E05Coins
{
    class Coins
    {
        static void Main()
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int coinsChange = 0;

            while (change > 0)
            {
                if (change - 200 >= 0)
                {
                    change -= 200;
                    coinsChange++;
                }
                else if (change - 100 >= 0)
                {
                    change -= 100;
                    coinsChange++;
                }
                else if (change - 50 >= 0)
                {
                    change -= 50;
                    coinsChange++;
                }
                else if (change - 20 >= 0)
                {
                    change -= 20;
                    coinsChange++;
                }
                else if (change - 10 >= 0)
                {
                    change -= 10;
                    coinsChange++;
                }
                else if (change - 5 >= 0)
                {
                    change -= 5;
                    coinsChange++;
                }
                else if (change - 2 >= 0)
                {
                    change -= 2;
                    coinsChange++;
                }
                else if (change - 1 >= 0)
                {
                    change -= 1;
                    coinsChange++;
                }
            }

            Console.WriteLine(coinsChange);
        }
    }
}
