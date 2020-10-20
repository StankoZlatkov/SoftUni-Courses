using System;

namespace E09KaminoFactory
{
    class KaminoFactory
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] bestArray = new int[arrayLength];
            int maxSum = 0;
            int bestIndex = int.MaxValue;
            int bestCount = 0;
            int sample = 0;
            int bestSample = 0;

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                string[] arrayString = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);

                int[] array = new int[arrayLength];
                sample++;


                // запълване на масива
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(arrayString[i]);
                }
                //край на запълването на масива

                // сумиране на масива
                int sum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == 0)
                    {
                        continue;
                    }
                    sum += array[j];
                }
                // край на сумирането на масива

                // намиране на най-дългата пордеца в масива
                int index = 0;
                int maxCount = 0;
                int count = 0;

                for (int k = 0; k < array.Length; k++)
                {
                    if (array[k] == 0)
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        index = (k - count) + 1;
                    }
                }
                //край на намирането на най-дългата пордеца в масива

                //сравняване на масивите
                bool isCount = false;
                bool isIndex = false;
                bool isSum = false;

                if (maxCount > bestCount)
                {
                    isCount = true;
                }
                else if (maxCount == bestCount && index < bestIndex)
                {
                    isIndex = true;
                }
                else if (maxCount == bestCount && bestIndex == index && sum > maxSum)
                {
                    isSum = true;
                }

                if (isCount || isIndex || isSum)
                {
                    for (int l = 0; l < array.Length; l++)
                    {
                        bestArray[l] = array[l];
                    }
                    bestSample = sample;
                    bestCount = maxCount;
                    bestIndex = index;
                    maxSum = sum;
                }
                //край на сравняването на масивите
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {maxSum}.");
            foreach (var item in bestArray)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine();
        }
    }
}
