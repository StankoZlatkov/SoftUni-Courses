using System;

namespace L06NumberInRange
{
    class NumberInRange
    {
        static void Main()
        {
            float inputNumber = float.Parse(Console.ReadLine());
            string inRange = string.Empty;

            if (inputNumber > 100 || inputNumber < -100 || inputNumber == 0)
            {
                inRange = "No";
            }
            else
            {
                inRange = "Yes";
            }
            Console.WriteLine(inRange);
        }
    }
}
