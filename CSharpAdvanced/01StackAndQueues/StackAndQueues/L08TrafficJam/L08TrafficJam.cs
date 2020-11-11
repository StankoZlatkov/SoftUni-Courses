
using System;
using System.Collections.Generic;
using System.Linq;

namespace L08TrafficJam
{
    class TrafficJam
    {
        static void Main()
        {
            int trafficJamCapacity = int.Parse(Console.ReadLine());

            var carList = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 1; i <= trafficJamCapacity; i++)
                    {
                        if (carList.Any())
                        {
                            Console.WriteLine($"{carList.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    carList.Enqueue(command);
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}