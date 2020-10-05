namespace E08FishTank
{
    using System;

    class FishTank
    {
        static void Main()
        {
            int aquariumLenght = int.Parse(Console.ReadLine());
            int aquariumWidht = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double aquariumVolume = (aquariumLenght * aquariumWidht * aquariumHeight) / 1000d;
            double needWater = aquariumVolume * (1 - percent);

            Console.WriteLine(needWater);
        }
    }
}
