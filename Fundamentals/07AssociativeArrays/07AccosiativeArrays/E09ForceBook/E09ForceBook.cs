using System;
using System.Collections.Generic;
using System.Linq;

namespace E09ForceBook
{
    class ForceBook
    {
        static void Main()
        {
            var list = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                string action = string.Empty;
                string side = string.Empty;
                string user = string.Empty;

                if (input.Contains('|'))
                {
                    string[] array = input.Split(" | ").ToArray();
                    action = "|";
                    side = array[0];
                    user = array[1];
                }
                else if (input.Contains("->"))
                {
                    string[] array = input.Split(" -> ").ToArray();
                    action = "->";
                    user = array[0];
                    side = array[1];
                }

                if (!list.ContainsKey(side))
                {
                    list.Add(side, new List<string>());
                }

                if (!list[side].Contains(user) && action == "|")
                {

                    list[side].Add(user);

                }

                if (action == "->")
                {
                    foreach (var sides in list)
                    {
                        if (sides.Value.Contains(user))
                        {
                            sides.Value.Remove(user);
                        }
                    }
                    list[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }
            foreach (var side in list.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var name in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
            }
        }
    }
}
