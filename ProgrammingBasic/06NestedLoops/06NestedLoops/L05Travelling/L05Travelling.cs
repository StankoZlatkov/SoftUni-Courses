using System;

namespace L05Travelling
{
    class Travelling
    {
        static void Main()
        {
            string destination = string.Empty;
            double needMoney = 0;
            double saveMoney = 0;

            while (destination != "End")
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                needMoney = double.Parse(Console.ReadLine());
                double saveSum = 0;

                while (saveSum < needMoney)
                {
                    saveMoney = double.Parse(Console.ReadLine());
                    saveSum += saveMoney;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
