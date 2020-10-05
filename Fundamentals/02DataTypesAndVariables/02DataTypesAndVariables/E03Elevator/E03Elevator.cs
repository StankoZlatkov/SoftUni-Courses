using System;

namespace E03Elevator
{
    class Elevator
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int rounds = 0;

            while (numberOfPeople > 0)
            {
                numberOfPeople -= elevatorCapacity;
                rounds++;
            }

            Console.WriteLine(rounds);
        }
    }
}
