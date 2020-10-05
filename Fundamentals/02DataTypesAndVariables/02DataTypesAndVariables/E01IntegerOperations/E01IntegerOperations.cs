using System;

namespace E01IntegerOperations
{
    class IntegerOperations
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondtNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int result = ((firstNumber + secondtNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(result);
        }
    }
}
