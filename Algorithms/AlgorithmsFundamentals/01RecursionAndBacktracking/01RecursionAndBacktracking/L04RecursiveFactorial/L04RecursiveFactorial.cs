using System;

namespace L04RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int factoriel = GetFactoriel(number);

            Console.WriteLine(factoriel);
        }

        private static int GetFactoriel(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * GetFactoriel(number - 1);
        }
    }
}
