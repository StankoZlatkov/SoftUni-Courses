﻿using System;

namespace E02BonusScore
{
    class E02BonusScore
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (inputNumber <= 100)
            {
                bonus += 5;
            }
            else if (inputNumber <= 1000)
            {
                bonus += inputNumber * 0.2;
            }
            else if (inputNumber > 1000)
            {
                bonus += inputNumber * 0.1;
            }

            if (inputNumber % 2 == 0)
            {
                bonus += 1;
            }
            if (inputNumber % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + inputNumber);
        }
    }
}
