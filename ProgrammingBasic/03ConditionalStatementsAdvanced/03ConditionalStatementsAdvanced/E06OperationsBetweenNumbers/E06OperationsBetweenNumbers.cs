using System;

namespace E06OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            if (n2 == 0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (sign == "/")
            {
                double result = n1 / n2;
                Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, result);
            }
            else if (sign == "%")
            {
                double result = n1 % n2;
                Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
            }
            else if (sign == "-")
            {
                double result = n1 - n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result);
                }
            }
            else if (sign == "+")
            {
                double result = n1 + n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
                }
            }
            else if (sign == "*")
            {
                double result = n1 * n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result);
                }
            }
        }
    }
}
