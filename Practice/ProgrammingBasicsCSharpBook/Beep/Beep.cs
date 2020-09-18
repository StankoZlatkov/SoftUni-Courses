namespace Beep
{
    using System;

    class Beep
    {
        static void Main()
        {
            for (int i = 100; i < 4000; i++)
            {
                Console.Beep(i, 500);
            }
        }
    }
}
