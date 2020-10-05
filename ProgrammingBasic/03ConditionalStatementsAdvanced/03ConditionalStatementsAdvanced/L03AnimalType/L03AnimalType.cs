using System;

namespace L03AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string animal = Console.ReadLine();
            string animalType = string.Empty;

            switch (animal)
            {
                case "crocodile":
                case "snake":
                case "tortoise":
                    animalType = "reptile";
                    break;
                case "dog":
                    animalType = "mammal";
                    break;
                default:
                    animalType = "unknown";
                    break;
            }

            Console.WriteLine(animalType);
        }
    }
}
