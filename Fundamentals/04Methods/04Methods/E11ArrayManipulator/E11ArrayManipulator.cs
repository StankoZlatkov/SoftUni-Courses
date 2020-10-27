using System;
using System.Linq;

namespace E11ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            string arrayInput = Console.ReadLine();
            string[] arrayStr = arrayInput.Split(' ');
            int[] arrayInt = new int[arrayStr.Length];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = int.Parse(arrayStr[i]);
            }


            while (true)
            {
                string command = Console.ReadLine();
                string[] commandStr = command.Split(' ');
                if (commandStr[0] == "end")
                {
                    break;
                }
                ExchangeArray(arrayInt, commandStr);
            }
        }
        public static void ExchangeArray(int[] array, string[] command)
        {
            int index = 0;

            foreach (var item in command)
            {
                index = int.Parse(command[1]);
            }

            if (index >= array.Length || index < 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int[] firstPart = array.Take(index).ToArray();
                int[] secondPart = array.Skip(index).ToArray();
                array = secondPart.Concat(firstPart).ToArray();
            }
        }
        public static void ReturnMaxOrMinOddOrEveneElement(int[] array, string[] command)
        {
            if (command[0] == "max")
            {
                int max = -1;
                if (command[1] == "odd")
                {
                    max = array.Max();
                }
                else if (command[1] == "even")
                {
                    max = array.Max();
                }
            }
            else if (command[0] == "min")
            {
                if (command[1] == "odd")
                {

                }
                else if (command[1] == "even")
                {

                }
            }
        }
    }
}
