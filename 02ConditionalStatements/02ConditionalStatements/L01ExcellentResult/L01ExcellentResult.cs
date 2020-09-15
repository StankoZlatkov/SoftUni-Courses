using System;

namespace L01ExcellentResult
{
    class ExcellentResult
    {
        static void Main()
        {
            float grade = float.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
