namespace E05FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FashionBoutique
    {
        static void Main()
        {
            Stack <int> clothDelivery = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int newRack = rackCapacity;
            int racks = 0;

            while (clothDelivery.Count != 0)
            {
                while (newRack >= 0 && newRack - clothDelivery.First() >= 0)
                {
                    newRack -= clothDelivery.Pop();
                    if (clothDelivery.Count == 0)
                    {
                        break;
                    }
                }
                newRack = rackCapacity;
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
