using System;
using System.Collections.Generic;

namespace L04ListOfProducts
{
    class ListOfProducts
    {
        static void Main()
        {
            int productsQty = int.Parse(Console.ReadLine());
            var productList = new List<string>();

            for (int i = 0; i < productsQty; i++)
            {
                productList.Add(Console.ReadLine());
            }

            productList.Sort();

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productList[i]}");
            }
        }
    }
}
