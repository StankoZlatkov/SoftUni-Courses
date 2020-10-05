using System;

namespace E03SpeedInfo
{
    class SpeedInfo
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            string speedType = string.Empty;

            if (speed <= 10)
            {
                speedType = "slow";
            }
            else if (speed <= 50)
            {
                speedType = "average";
            }
            else if (speed <= 150)
            {
                speedType = "fast";
            }
            else if (speed <= 1000)
            {
                speedType = "ultra fast";
            }
            else if (speed > 1000)
            {
                speedType = "extremely fast";
            }

            Console.WriteLine(speedType);
        }
    }
}
