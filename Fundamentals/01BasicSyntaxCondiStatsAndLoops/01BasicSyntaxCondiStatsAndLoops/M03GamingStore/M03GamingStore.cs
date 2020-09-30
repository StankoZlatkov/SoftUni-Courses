using System;

namespace M03GamingStore
{
    class GamingStore
    {
        static void Main()
        {
            float startBalance = float.Parse(Console.ReadLine());
            string gameInput = Console.ReadLine();
            float price = 0;
            float balance = startBalance;
            float spentSum = 0;
            bool incorrectGame = true;

            while (gameInput != "Game Time")
            {
                switch (gameInput)
                {
                    case "CS: OG":
                        price = 15.99f;
                        incorrectGame = false;
                        break;
                    case "Zplinter Zell":
                        price = 19.99f;
                        incorrectGame = false;
                        break;
                    case "RoverWatch":
                        price = 29.99f;
                        incorrectGame = false;
                        break;
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99f;
                        incorrectGame = false;
                        break;
                    case "Honored 2":
                        price = 59.99f;
                        incorrectGame = false;
                        break;
                    default:
                        price = 0;
                        break;
                }
                if (price >= balance)
                {
                    Console.WriteLine("Too Expensive");
                    gameInput = Console.ReadLine();
                    continue;
                }
                else if (incorrectGame)
                {
                    Console.WriteLine("Not Found");
                    gameInput = Console.ReadLine();
                    continue;
                }
                balance -= price;
                spentSum += price;
                if (balance <= 0)
                {
                    break;
                }
                Console.WriteLine($"Bought {gameInput}");
                gameInput = Console.ReadLine();
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                float reminding = startBalance - spentSum;
                Console.WriteLine($"Total spent: ${spentSum:f2}. Remaining: ${reminding:f2}");
            }
        }
    }
}
