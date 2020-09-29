using System;

namespace E02EqualSumsEvenOddPosition
{
    class EqualSumsEvenOddPosition
    {
        static void Main()
        {
            int firstNumberInput = int.Parse(Console.ReadLine());
            int lastNumberInput = int.Parse(Console.ReadLine());

            for (int i = firstNumberInput; i <= lastNumberInput; i++)
            {
                string currentNumber = i.ToString();

                int evenPositionSum = 0;
                int oddPositionSum = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenPositionSum += int.Parse(currentNumber[j].ToString());
                    }
                    else
                    {
                        oddPositionSum += int.Parse(currentNumber[j].ToString());
                    }
                }
                if (evenPositionSum == oddPositionSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
