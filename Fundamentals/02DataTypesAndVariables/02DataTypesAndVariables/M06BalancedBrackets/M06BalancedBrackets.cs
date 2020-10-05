using System;

namespace M06BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClose = 0;
            bool balanced = false;

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpen++;
                }
                if (input == ")" && countOpen == 1 && countClose == 0)
                {
                    countOpen = 0;
                    balanced = true;
                }
                else if (input == ")")
                {
                    countClose++;
                }
            }

            if (balanced && countClose == 0 && countOpen == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
