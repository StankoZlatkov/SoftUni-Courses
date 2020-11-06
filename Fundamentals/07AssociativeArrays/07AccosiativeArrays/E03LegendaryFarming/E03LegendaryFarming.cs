using System;
using System.Collections.Generic;
using System.Linq;

namespace E03LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {

            bool shadowmourne = false;
            bool valanyr = false;
            bool dragonwrath = false;

            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            var junkMaterials = new SortedDictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] array = input.Split().ToArray();

                for (int i = 0; i < array.Length; i++)
                {
                    int qty = int.Parse(array[i]);
                    string material = array[i + 1].ToLower();
                    i++;

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += qty;

                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            shadowmourne = true;
                            break;
                        }
                        if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            valanyr = true;
                            break;
                        }
                        if (keyMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            dragonwrath = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, qty);
                        }
                        else
                        {
                            junkMaterials[material] += qty;
                        }
                    }
                }
                if (shadowmourne == true || valanyr == true || dragonwrath == true)
                {
                    break;
                }
            }
            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
