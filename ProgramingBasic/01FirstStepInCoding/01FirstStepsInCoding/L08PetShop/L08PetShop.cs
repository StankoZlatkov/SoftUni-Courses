namespace L08PetShop
{
    using System;

    class PetShop
    {
        static void Main()
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            double otherAnimalFoodPrice = 4;

            double totalPrice = (dogs * dogFoodPrice) + (otherAnimals * otherAnimalFoodPrice);

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
