using System;

namespace L08GraduationPt2
{
    class GraduationPt2
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int counter = 1;
            double badGrade = 0;
            double sum = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    badGrade++;
                    if (badGrade > 1)
                    {
                        break;
                    }
                }
                else if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;
                }
            }
            double average = sum / 12;

            if (counter >= 12)
            {
                Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, average);
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
        }
    }
}
