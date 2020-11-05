using System;
using System.Collections.Generic;
using System.Linq;

namespace E02AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            var resourcesList = new Dictionary<string, int>();
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int qty = int.Parse(Console.ReadLine());

                if (!resourcesList.ContainsKey(command))
                {
                    resourcesList.Add(command, 0);
                }
                
                resourcesList[command] += qty;
            }

            foreach (var resource in resourcesList)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
