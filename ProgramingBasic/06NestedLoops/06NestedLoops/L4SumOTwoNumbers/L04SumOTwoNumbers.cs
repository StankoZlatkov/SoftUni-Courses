using System;

namespace L04SumOTwoNumbers
{
    class SumOTwoNumbers
    {
        static void Main()
        {
            int firstInputNumber = int.Parse(Console.ReadLine());
            int lastInputNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int firstMagicNumber = 0;
            int lastMagicNumber = 0;
            int combinationNumber = 0;
            bool isMagic = false;

            for (int n1 = firstInputNumber; n1 <= lastInputNumber; n1++)
            {
                for (int n2 = firstInputNumber; n2 <= lastInputNumber; n2++)
                {
                    combinationNumber++;
                    if (n1 + n2 == magicNumber)
                    {
                        firstMagicNumber = n1;
                        lastMagicNumber = n2;
                        isMagic = true;
                        break;
                    }
                }
                if (isMagic)
                {
                    break;
                }
            }

            if (isMagic)
            {
                Console.WriteLine($"Combination N:{combinationNumber} ({firstMagicNumber} + {lastMagicNumber} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{combinationNumber} combinations - neither equals {magicNumber}");
            }
        }
    }
}
