using System;

namespace M04RefactoringPrimeChecker
{
    class RefactoringPrimeChecker
    {
        static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= maxNumber; number++)
            {
                bool isprime = true;
                for (int cepitel = 2; cepitel < number; cepitel++)
                {
                    if (number % cepitel == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, isprime.ToString().ToLower());
            }
        }
    }
}
