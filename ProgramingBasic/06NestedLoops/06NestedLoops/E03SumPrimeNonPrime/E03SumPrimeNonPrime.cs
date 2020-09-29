using System;

namespace E03SumPrimeNonPrime
{
    class SumPrimeNonPrime
    {
        static void Main()
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                bool isPrime = true;

                if (input == "stop")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
