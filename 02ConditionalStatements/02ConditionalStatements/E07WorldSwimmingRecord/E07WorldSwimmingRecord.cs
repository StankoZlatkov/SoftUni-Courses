using System;

namespace E07WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double swimRecordInSeconds = double.Parse(Console.ReadLine());
            double swimDistanceInMeters = double.Parse(Console.ReadLine());
            double swimSpeedSecondsPerMeter = double.Parse(Console.ReadLine());

            double delayInSeconds = (Math.Truncate(swimDistanceInMeters / 15)) * 12.5;

            double swimerRecordInSecond = (swimDistanceInMeters * swimSpeedSecondsPerMeter) + delayInSeconds;

            if (swimRecordInSeconds > swimerRecordInSecond)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimerRecordInSecond:f2} seconds.");
            }
            else if (swimRecordInSeconds <= swimerRecordInSecond)
            {
                double needSeconds = swimerRecordInSecond - swimRecordInSeconds;
                Console.WriteLine($"No, he failed! He was {needSeconds:f2} seconds slower.");
            }
        }
    }
}
