using System;

namespace C1T10
{
    class C1T10
    {
        static void Main()
        {
            int num = 2;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(num);
                num = Math.Abs(num);
                num++;
                if (num % 2 != 0)
                {
                    num /= -1;
                }
            }
        }
    }
}
