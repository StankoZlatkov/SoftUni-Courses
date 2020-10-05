using System;

namespace E05PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= stopIndex; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
