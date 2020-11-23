using System;

namespace L03GeneratingBinaryVectors
{
    class GeneratingBinaryVectors
    {
        static void Main()
        {
            int bits = int.Parse(Console.ReadLine());

            int[] vectorArray = new int[bits];

            PrintBinaryVector(vectorArray);
        }

        private static void PrintBinaryVector(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join('', array));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    array[index] = i;
                    PrintBinaryVector(array, index + 1);
                }
            }
        }
    }
}
