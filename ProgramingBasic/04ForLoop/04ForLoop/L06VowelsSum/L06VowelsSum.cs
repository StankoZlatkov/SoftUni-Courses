using System;

namespace L06VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();
            int sum = 0;

            

            for (int i = 0; i < inputWord.Length; i++)
            {
                char symbol = inputWord[i];
                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
