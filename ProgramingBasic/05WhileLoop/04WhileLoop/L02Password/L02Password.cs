using System;

namespace L02Password
{
    class L02Password
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string userInputPassword = string.Empty;

            while (userInputPassword != password)
            {
                userInputPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
