using System;

namespace E06Salary
{
    class Salary
    {
        static void Main()
        {
            double openTabs = double.Parse(Console.ReadLine());
            double selary = double.Parse(Console.ReadLine());

            string site = string.Empty;
            double forfeit = 0;

            for (int i = 1; i <= openTabs; i++)
            {
                site = Console.ReadLine();

                if (site == "Facebook")
                {
                    forfeit = 150;
                }
                else if (site == "Instagram")
                {
                    forfeit = 100;
                }
                else if (site == "Reddit")
                {
                    forfeit = 50;
                }
                else
                {
                    forfeit = 0;
                }

                selary -= forfeit;

                if (selary <= 0)
                {
                    break;
                }
            }
            if (selary > 0)
            {
                Console.WriteLine(selary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
