using System;

namespace L12TradeCommissions
{
    class TradeCommissions
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double commission = -1;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commission = sales * 0.07;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                }
            }

            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commission = sales * 0.075;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commission = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                }
            }

            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commission = sales * 0.08;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                }
            }

            if (commission >= 0)
            {
                Console.WriteLine("{0:F2}", commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
