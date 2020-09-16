using System;

namespace L10InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            short inputNumber = short.Parse(Console.ReadLine());

            if ((inputNumber < 100 || inputNumber > 200) && inputNumber != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
