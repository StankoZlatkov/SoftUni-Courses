using System;
using System.Collections.Generic;
using System.Linq;

namespace L06ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main()
        {

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "end")
                {
                    break;
                }
                string action = comand.Split(' ')[0];

                if (action == "Add")
                {
                    AddToList(comand, input);
                }
                else if (action == "Remove")
                {
                    RemoveNum(comand, input);
                }
                else if (action == "RemoveAt")
                {
                    RemoveIndex(comand, input);
                }
                else if (action == "Insert")
                {
                    Insert(comand, input);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static public List<int> AddToList(string cmd, List<int> input)
        {
            int addNum = int.Parse(cmd.Split(' ')[1]);

            input.Add(addNum);

            return input;
        }
        static public List<int> RemoveNum(string cmd, List<int> input)
        {
            int removeNum = int.Parse(cmd.Split(' ')[1]);

            input.Remove(removeNum);

            return input;
        }
        static public List<int> RemoveIndex(string cmd, List<int> input)
        {
            int index = int.Parse(cmd.Split(' ')[1]);

            input.RemoveAt(index);

            return input;
        }
        static public List<int> Insert(string cmd, List<int> input)
        {
            int index = int.Parse(cmd.Split(' ')[1]);
            int number = int.Parse(cmd.Split(' ')[2]);

            input.Insert(number, index);

            return input;
        }
    }
}
