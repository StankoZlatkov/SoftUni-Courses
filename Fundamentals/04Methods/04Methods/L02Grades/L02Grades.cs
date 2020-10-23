using System;

namespace L02Grades
{
    class Grades
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGrade(grade);
        }

        public static void PrintGrade(double grade)
        {
            if (grade < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
