using System;

namespace E10PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int pokePowerStart = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int count = 0;
            int pokePowerMoment = pokePowerStart;

            while (pokePowerMoment >= distance)
            {
                count++;
                pokePowerMoment -= distance;

                if (pokePowerMoment == pokePowerStart / 2 && exhaustionFactorY != 0)
                {
                    pokePowerMoment /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePowerMoment);
            Console.WriteLine(count);
        }
    }
}
