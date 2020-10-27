using System;

namespace E09PalindromeIntegers
{
    class E09PalindromeIntegers
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                char[] arrayChar = input.ToCharArray();
                int[] arrayInt = new int[arrayChar.Length];

                for (int i = 0; i < arrayInt.Length; i++)
                {
                    arrayInt[i] = (int)arrayChar[i];
                }
                IsArraySymmetric(arrayInt);
            }
        }

        public static void IsArraySymmetric(int[] arrayInt)
        {
            bool isEqual = true;
            for (int i = 0, j = arrayInt.Length - 1; i <= j; i++, j--)
            {
                if (arrayInt[i] != arrayInt[j])
                {
                    isEqual = false;
                }
            }
            Console.WriteLine(isEqual.ToString().ToLower());
        }
    }
}
