using System;

namespace E04Walking
{
    class Walking
    {
        static void Main()
        {
            string input;
            int traget = 10000;
            int sumSteps = 0;

            while (sumSteps < traget)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    int homeSteps = int.Parse(Console.ReadLine());
                    sumSteps += homeSteps;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    sumSteps += steps;
                }
            }

            if (sumSteps < traget)
            {
                int differenceSteps = 10000 - sumSteps;
                Console.WriteLine($"{differenceSteps} more steps to reach goal.");
            }
            else
            {
                int differenceSteps = sumSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{differenceSteps} steps over the goal!");
            }
        }
    }
}
