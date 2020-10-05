using System;
using System.Numerics;

namespace E11Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger highestVolume = 0;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballVolume = (BigInteger)(Math.Pow((snowballSnow / snowballTime), snowballQuality));

                if (snowballVolume > highestVolume)
                {
                    highestVolume = snowballVolume;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestVolume} ({bestSnowballQuality})");
        }
    }
}
