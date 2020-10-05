using System;

namespace L11FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double qty = double.Parse(Console.ReadLine());
            double price = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") price = 2.5;
                else if (fruit == "kiwi") price = 2.7;
                else if (fruit == "grapes") price = 3.85;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "apple") price = 1.2;
                else if (fruit == "pineapple") price = 5.5;
            }

            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") price = 2.7;
                else if (fruit == "kiwi") price = 3;
                else if (fruit == "grapes") price = 4.2;
                else if (fruit == "orange") price = 0.9;
                else if (fruit == "grapefruit") price = 1.6;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "pineapple") price = 5.6;
            }

            if (price >= 0)
            {
                Console.WriteLine("{0:F2}", price * qty);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
