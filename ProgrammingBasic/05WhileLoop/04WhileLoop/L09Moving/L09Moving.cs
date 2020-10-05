using System;

namespace L09Moving
{
    class Moving
    {
        static void Main()
        {
            int widht = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int homeVolume = widht * length * height;
            int sumVolume = 0;

            while (sumVolume <= homeVolume)
            {
                if (input == "Done")
                {
                    break;
                }
                else
                {
                    int boxVolume = 0;
                    boxVolume = int.Parse(input);
                    input = Console.ReadLine();
                    sumVolume += boxVolume;
                }
            }

            if (input == "Done")
            {
                int freeVolume = homeVolume - sumVolume;
                Console.WriteLine("{0} Cubic meters left.", freeVolume);
            }
            else
            {
                int needVolume = sumVolume - homeVolume;
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", needVolume);
            }
        }
    }
}
