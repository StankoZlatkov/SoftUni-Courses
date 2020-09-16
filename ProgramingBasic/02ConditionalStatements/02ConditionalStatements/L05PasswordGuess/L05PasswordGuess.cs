namespace L05PasswordGuess
{
    using System;

    class PasswordGuess
    {
        static void Main()
        {
            string inputPassword = Console.ReadLine();
            string correctPassword = "s3cr3t!P@ssw0rd";

            if (inputPassword == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
