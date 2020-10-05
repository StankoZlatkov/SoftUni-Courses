using System;

namespace L09FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string product = Console.ReadLine();

            if (product == "banana" || product == "grapes" || product == "cherry" || product == "apple" || product == "kiwi" || product == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
