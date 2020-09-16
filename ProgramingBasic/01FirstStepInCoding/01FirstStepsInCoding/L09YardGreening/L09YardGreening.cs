namespace L09YardGreening
{
    using System;

    class YardGreening
    {
        static void Main()
        {
            double gardenArea = double.Parse(Console.ReadLine());
            double pricePerSqrMeter = 7.61;
            double discountPercent = 0.18;

            double totalPrice = gardenArea * pricePerSqrMeter;
            double discount = (gardenArea * pricePerSqrMeter * discountPercent * 100) / 100;
            double finalPrice = totalPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
