using System;
using System.Linq;

namespace E01Train
{
    class E01Train
    {
        static void Main()
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];

            for (int i = 0; i < train.Length; i++)
            {
                int passagers = int.Parse(Console.ReadLine());
                train[i] = passagers;
            }

            int allPassagers = train.Sum();

            for (int i = 0; i < wagons ; i++)
            {
                Console.Write($"{train[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(allPassagers);
        }
    }
}
