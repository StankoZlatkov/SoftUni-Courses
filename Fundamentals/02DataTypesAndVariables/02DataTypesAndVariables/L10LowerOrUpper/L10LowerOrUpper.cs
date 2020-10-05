using System;

namespace L10LowerOrUpper
{
    class LowerOrUpper
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            bool isUpper = (Char.IsUpper(input));

            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
