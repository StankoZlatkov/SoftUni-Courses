using System;

namespace E09PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main()
        {
            float money = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float singleLightsabrePrice = float.Parse(Console.ReadLine());
            float singleRobePrice = float.Parse(Console.ReadLine());
            float singleBeltPrice = float.Parse(Console.ReadLine());

            double robesPrice = students * singleRobePrice;
            double lightcabresprice = Math.Ceiling(students * 1.1) * singleLightsabrePrice;
            double beltsprice = (students - students / 6) * singleBeltPrice;

            double sum = robesPrice + lightcabresprice + beltsprice;

            if (sum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(sum - money):f2}lv more.");
            }
        }
    }
}
