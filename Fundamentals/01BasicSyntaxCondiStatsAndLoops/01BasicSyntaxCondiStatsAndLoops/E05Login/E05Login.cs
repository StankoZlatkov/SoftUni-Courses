using System;
using System.Linq;

namespace E05Login
{
    class Login
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            int count = 0;

            while (true)
            {
                count++;
                string userNameInput = Console.ReadLine();
                string userNameCorrect = new string(userNameInput.Reverse().ToArray());

                if (userNameCorrect == userName)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (count >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
