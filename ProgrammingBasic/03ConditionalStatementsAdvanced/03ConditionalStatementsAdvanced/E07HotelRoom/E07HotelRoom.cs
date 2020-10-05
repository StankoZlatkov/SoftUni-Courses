using System;

namespace E07HotelRoom
{
    class E07HotelRoom
    {
        static void Main()
        {
            string mounth = Console.ReadLine();
            double overnight = double.Parse(Console.ReadLine());

            double apartamentPrice = 0;
            double studioPrice = 0;
            double studioDiscount = 1;
            double apartamentDiscount = 1;

            switch (mounth)
            {
                case "May":
                case "October":
                    apartamentPrice = 65;
                    studioPrice = 50;

                    if (overnight > 14)
                    {
                        apartamentDiscount = 0.9;
                        studioDiscount = 0.7;
                    }
                    else if (overnight > 7)
                    {
                        studioDiscount = 0.95;
                    }
                    break;

                case "June":
                case "September":
                    apartamentPrice = 68.7;
                    studioPrice = 75.2;

                    if (overnight > 14)
                    {
                        apartamentDiscount = 0.9;
                        studioDiscount = 0.8;
                    }

                    break;

                case "July":
                case "August":
                    apartamentPrice = 77;
                    studioPrice = 76;

                    if (overnight > 14)
                    {
                        apartamentDiscount = 0.9;
                    }

                    break;
            }
            double apartamentMoney = (apartamentPrice * overnight) * apartamentDiscount;
            double studioMoney = (studioPrice * overnight) * studioDiscount;
            Console.WriteLine("Apartment: {0:F2} lv.", apartamentMoney);
            Console.WriteLine("Studio: {0:F2} lv.", studioMoney);
        }
    }
    
}
