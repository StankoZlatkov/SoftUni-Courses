using System;
using System.Collections.Generic;
using System.Linq;

namespace L05RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> nums = input.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                    i = -1;
                }
            }
            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
