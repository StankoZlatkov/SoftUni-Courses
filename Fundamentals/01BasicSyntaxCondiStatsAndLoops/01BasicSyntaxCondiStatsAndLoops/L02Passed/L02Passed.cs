using System;

namespace L02Passed
{
    class Passed
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
