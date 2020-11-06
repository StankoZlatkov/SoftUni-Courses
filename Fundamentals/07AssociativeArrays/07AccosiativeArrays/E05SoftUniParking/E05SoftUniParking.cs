using System;
using System.Collections.Generic;
using System.Linq;

namespace E05SoftUniParking
{
    class SoftUniParking
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, string>();

            for (int i = 1; i <= lines; i++)
            {
                string command = Console.ReadLine();
                string[] array = command.Split(' ').ToArray();

                if (array[0] == "register" && !list.ContainsKey(array[1]))
                {
                    list.Add(array[1], array[2]);
                    Console.WriteLine($"{array[1]} registered {array[2]} successfully");
                }
                else if (array[0] == "register" && list.ContainsKey(array[1]))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {array[2]}");
                }
                else if (array[0] == "unregister" && list.ContainsKey(array[1]))
                {
                    Console.WriteLine($"{array[1]} unregistered successfully");
                    list.Remove(array[1]);
                }
                else if (array[0] == "unregister" && !list.ContainsKey(array[1]))
                {
                    Console.WriteLine($"ERROR: user {array[1]} not found");
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
