using System;

namespace L01Clock
{
    class Clock
    {
        static void Main()
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");
                }
            }
        }
    }
}
