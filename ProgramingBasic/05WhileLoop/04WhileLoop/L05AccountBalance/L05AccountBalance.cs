using System;

namespace L05AccountBalance
{
    class AccountBalance
    {
        static void Main()
        {
            double total = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "NoMoreMoney")
                {
                    break;
                }

                double sum = double.Parse(command);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += sum;
                Console.WriteLine($"Increase: {sum:f2}");
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
