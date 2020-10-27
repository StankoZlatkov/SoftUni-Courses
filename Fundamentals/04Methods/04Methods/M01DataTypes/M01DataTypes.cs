using System;

namespace M01DataTypes
{
    class DataTypes
    {
        static void Main()
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "int":
                    int inputInt = int.Parse(Console.ReadLine());
                    PrintResult(inputInt);
                    break;
                case "real":
                    double inputReal = double.Parse(Console.ReadLine());
                    PrintResult(inputReal);
                    break;
                case "string":
                    string inputText = Console.ReadLine();
                    PrintResult(inputText);
                    break;
            }
        }

        public static void PrintResult(int input)
        {
            Console.WriteLine(input * 2);
        }

        public static void PrintResult(double input)
        {
            Console.WriteLine($"{(input * 1.5):f2}");
        }

        public static void PrintResult(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
