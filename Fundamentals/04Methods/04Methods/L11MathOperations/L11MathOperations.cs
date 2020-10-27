using System;

namespace L11MathOperations
{
    class MathOperations
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operatorIs = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = GetResult(firstNumber, operatorIs, secondNumber);
            Console.WriteLine(result);
        }
        private static double GetResult(double first, string oprtr, double second)
        {
            double result = 0;
            if (oprtr == "+")
            {
                result = first + second;
            }
            else if (oprtr == "-")
            {
                result = first - second;
            }
            else if (oprtr == "*")
            {
                result = first * second;
            }
            else if (oprtr == "/")
            {
                result = first / second;
            }
            return result;
        }
    }
}
