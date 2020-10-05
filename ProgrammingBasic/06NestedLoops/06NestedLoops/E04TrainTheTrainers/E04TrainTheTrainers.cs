using System;

namespace E04TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main()
        {
            int judges = int.Parse(Console.ReadLine());

            double averageGradeCourse = 0;
            double averageGradeFinal = 0;
            int courses = 0;

            while (true)
            {
                string course = Console.ReadLine();

                if (course == "Finish")
                {
                    break;
                }
                double gradesSum = 0;

                for (int i = 0; i < judges; i++)
                {
                    gradesSum += double.Parse(Console.ReadLine());
                }

                averageGradeCourse = gradesSum / judges;
                Console.WriteLine($"{course} - {averageGradeCourse:f2}.");

                courses++;
                averageGradeFinal += averageGradeCourse;
            }

            averageGradeFinal /= courses;
            Console.WriteLine($"Student's final assessment is {averageGradeFinal:f2}.");
        }
    }
}
