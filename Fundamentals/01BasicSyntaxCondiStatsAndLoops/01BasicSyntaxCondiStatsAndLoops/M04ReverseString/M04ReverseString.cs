using System;
using System.Linq;

namespace M04ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            {
                string input = Console.ReadLine();
                string reverse = new string(input.Reverse().ToArray());

                Console.WriteLine(reverse);
            }
        }
    }
}
