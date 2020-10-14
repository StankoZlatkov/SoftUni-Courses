using System;
using System.Linq;

namespace L04ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] reverseArray = inputArray.Reverse().ToArray();

            foreach (var @string in reverseArray)
            {
                Console.Write($"{@string} ");
            }
            Console.WriteLine();

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    reverseArray[i] = inputArray[inputArray.Length - i - 1];
            //    Console.Write(reverseArray[i] + " ");
            //}
        }
    }
}
