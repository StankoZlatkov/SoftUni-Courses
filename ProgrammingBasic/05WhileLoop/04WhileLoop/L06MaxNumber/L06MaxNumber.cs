using System;

namespace L06MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int maxNumber = int.MinValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                int input = int.Parse(command);

                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
