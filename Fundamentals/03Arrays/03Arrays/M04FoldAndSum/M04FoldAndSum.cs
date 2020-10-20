using System;

namespace M04FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int[] firstArray = new int[array.Length / 4];
            int[] secondArray = new int[array.Length / 4];
            int[] thirthArray = new int[array.Length / 2];

            for (int j = 0; j < firstArray.Length; j++)
            {
                firstArray[j] = array[j];
            }
            Array.Reverse(firstArray);

            for (int k = secondArray.Length - 1, n = array.Length - 1; k >= 0; k--, n--)
            {
                secondArray[k] = array[n];
            }
            Array.Reverse(secondArray);

            for (int g = 0, b = array.Length / 4; g < thirthArray.Length; g++, b++)
            {
                thirthArray[g] = array[b];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                thirthArray[i] += firstArray[i];
            }
            for (int i = secondArray.Length - 1, j = thirthArray.Length - 1; i >= 0; i--, j--)
            {
                thirthArray[j] += secondArray[i];
            }

            foreach (var item in thirthArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
