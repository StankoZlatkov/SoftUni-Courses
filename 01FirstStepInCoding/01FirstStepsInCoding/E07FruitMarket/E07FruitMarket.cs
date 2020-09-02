namespace E07FruitMarket
{
    using System;

    class FruitMarket
    {
        static void Main()
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasWeight = double.Parse(Console.ReadLine());
            double portocalsWeight = double.Parse(Console.ReadLine());
            double raspberriesWeight = double.Parse(Console.ReadLine());
            double strawberriesWeight = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double portocalsPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;

            double totalSum = strawberriesWeight * strawberriesPrice 
                              + bananasWeight * bananasPrice 
                              + portocalsWeight * portocalsPrice 
                              + raspberriesWeight * raspberriesPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
