using System;

namespace L07MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int minNumber = int.MaxValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                int input = int.Parse(command);

                if (input < minNumber)
                {
                    minNumber = input;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
