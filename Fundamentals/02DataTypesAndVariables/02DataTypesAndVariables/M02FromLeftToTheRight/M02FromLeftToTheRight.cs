using System;

namespace M02FromLeftToTheRight
{
    class FromLeftToTheRight
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string output = string.Empty;


            for (int i = 0; i < number; i++)
            {
                string full = Console.ReadLine();
                int index = full.IndexOf(' ');
                string leftString = full.Substring(0, full.IndexOf(' '));
                string rightString = full.Substring(full.IndexOf(' '), full.Length - index);
                long left = long.Parse(leftString);
                long right = long.Parse(rightString);

                long digit = 0;
                long sum = 0;

                if (left > right)
                {
                    left = Math.Abs(left);
                    while (left > 0)
                    {
                        digit = left % 10;
                        left = left / 10;
                        sum += Math.Abs(digit);
                    }
                }
                else
                {
                    right = Math.Abs(right);
                    while (right > 0)
                    {
                        digit = right % 10;
                        right = right / 10;
                        sum += digit;
                    }
                }
                output += sum + "\n";
            }
            Console.WriteLine(output);
        }
    }
}
