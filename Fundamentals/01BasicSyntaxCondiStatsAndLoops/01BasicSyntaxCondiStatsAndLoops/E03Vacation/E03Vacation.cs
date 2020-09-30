using System;

namespace E03Vacation
{
    class Vacation
    {
        static void Main()
        {
            int group = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday": price = 8.45; break;
                    case "Saturday": price = 9.80; break;
                    case "Sunday": price = 10.46; break;
                }
                price *= group;
                if (group >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (day)
                {
                    case "Friday": price = 10.90; break;
                    case "Saturday": price = 15.60; break;
                    case "Sunday": price = 16; break;
                }
                if (group >= 100)
                {
                    group -= 10;
                }
                price *= group;
            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday": price = 15; break;
                    case "Saturday": price = 20; break;
                    case "Sunday": price = 22.50; break;
                }
                price *= group;
                if (group >= 10 && group <= 20)
                {
                    price *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
