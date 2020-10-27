using System;
using System.Linq;
using System.Collections.Generic;

namespace L09GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string inputType = Console.ReadLine();
            string result = string.Empty;

            switch (inputType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    result = GetGreaterValue(firstInt, secondInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    result = GetGreaterValue(firstChar, secondChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    result = GetGreaterValue(firstString, secondString);
                    break;
            }

            Console.WriteLine(result);
        }

        public static string GetGreaterValue(int first, int second)
        {
            return Math.Max(first, second).ToString();

        }
        public static string GetGreaterValue(char first, char second)
        {
            if (first > second)
            {
                return first.ToString();
            }
            else
            {
                return second.ToString();
            }
        }
        public static string GetGreaterValue(string first, string second)
        {
            int firstSum = 0;
            int secondSum = 0;

            foreach (var @char in first)
            {
                firstSum += (int)@char;
            }
            foreach (var @char in second)
            {
                secondSum += (int)@char;
            }
            if (firstSum > secondSum)
            {
                return first;
            }
            else
            {
                return second;
            }

        }
    }
}
