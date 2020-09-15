using System;

namespace E08Scholarship
{
    class Scholarship
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSelary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Truncate(minimalSelary * 0.35);
            double excellentScholarship = Math.Truncate(averageGrade * 25);

            bool checkSocialScholarship = false;
            bool checkExcellentScholarship = false;

            if (averageGrade >= 4.5 && averageGrade < 5.5 && income < minimalSelary)
            {
                checkSocialScholarship = true;
            }
            else if (averageGrade >= 5.5)
            {
                checkExcellentScholarship = true;
            }


            if (checkSocialScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (checkExcellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else if (checkExcellentScholarship || checkSocialScholarship && socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (checkExcellentScholarship || checkSocialScholarship && socialScholarship <= excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
