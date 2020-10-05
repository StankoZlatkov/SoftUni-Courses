using System;

namespace E09SpiceMustFlow
{
    class SpiceMustFlow
    {
        static void Main()
        {
            int startingYeild = int.Parse(Console.ReadLine());
            int workDays = 0;
            int storage = 0;

            while (startingYeild >= 100)
            {
                workDays++;
                storage += startingYeild;

                if (storage > 0)
                {
                    storage -= 26;
                }
                startingYeild -= 10;
            }
            if (storage > 0)
            {
                storage -= 26;
            }
            if (storage < 0)
            {
                storage = 0;
            }
            Console.WriteLine(workDays);
            Console.WriteLine(storage);
        }
    }
}
