using System;

namespace L03Numbers1ToNWithStep3
{
    class Numbers1ToNWithStep3
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
