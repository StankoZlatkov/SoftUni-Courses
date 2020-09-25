using System;

namespace E01OldBooks
{
    class OldBooks
    {
        static void Main()
        {
            string AniFavoriteBook = Console.ReadLine();
            int checkedBooks = 0;
            while (true)
            {
                string findBookCommand = Console.ReadLine();

                if (findBookCommand == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }

                if (findBookCommand == AniFavoriteBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                checkedBooks++;
            }
        }
    }
}
