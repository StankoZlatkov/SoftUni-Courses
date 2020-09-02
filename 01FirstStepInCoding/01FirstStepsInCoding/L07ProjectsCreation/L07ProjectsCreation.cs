namespace L07ProjectsCreation
{
    using System;

    class ProjectsCreation
    {
        static void Main()
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int projectTime = projects * 3;

            Console.WriteLine($"The architect {architectName} will need {projectTime} hours to complete {projects} project/s.");
        }
    }
}
