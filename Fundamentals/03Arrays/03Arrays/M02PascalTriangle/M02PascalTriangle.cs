using System;

namespace M02PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            ulong[] helpArray = new ulong[0];

            for (int i = 1; i <= lines; i++)
            {
                ulong[] rowArray = new ulong[i];
                rowArray[0] = 1;
                rowArray[rowArray.Length - 1] = 1;

                if (i > 2)
                {
                    for (int j = 1; j < rowArray.Length - 1; j++)
                    {
                        rowArray[j] = helpArray[j - 1] + helpArray[j];
                    }
                }

                helpArray = new ulong[i];
                for (int l = 0; l < rowArray.Length; l++)
                {
                    helpArray[l] = rowArray[l];
                }
                foreach (var item in helpArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
