﻿using System;

namespace L02MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{x} * {y} = {x * y}");
                }
            }
        }
    }
}
