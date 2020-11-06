using System;
using System.Collections.Generic;
using System.Linq;

namespace E06Courses
{
    class Courses
    {
        static void Main()
        {
            var list = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                string[] array = input.Split(" : ").ToArray();
                string course = array[0];
                string name = array[1];
                if (!list.ContainsKey(array[0]))
                {
                    list.Add(course, new List<string>());
                }

                list[course].Add(name);
            }

            foreach (var course in list.OrderByDescending(x => x.Value.Count))
            {
                int students = course.Value.Count;
                Console.WriteLine($"{course.Key}: {students}");
                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
