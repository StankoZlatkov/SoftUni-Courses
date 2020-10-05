using System;

namespace E02ExamPreparation
{
    class ExamPreparation
    {
        static void Main()
        {
            int badGrades = int.Parse(Console.ReadLine());
            string lastTask = string.Empty;
            int numberOfTasks = 0;
            int numberOfBadGrades = 0;
            double gradesSum = 0;
            double averageGrade = 0;

            while (true)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {numberOfTasks}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }

                int taskGrade = int.Parse(Console.ReadLine());

                numberOfTasks++;
                gradesSum += taskGrade;
                averageGrade = gradesSum / numberOfTasks;
                lastTask = taskName;

                if (taskGrade <= 4)
                {
                    numberOfBadGrades++;
                }
                if (numberOfBadGrades >= badGrades)
                {
                    Console.WriteLine($"You need a break, {numberOfBadGrades} poor grades.");
                    break;
                }
            }
        }
    }
}
