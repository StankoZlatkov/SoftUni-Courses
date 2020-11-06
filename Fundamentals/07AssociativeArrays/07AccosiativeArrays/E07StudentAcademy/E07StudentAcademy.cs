using System;
using System.Collections.Generic;
using System.Linq;

namespace E07StudentAcademy
{
    class StudentAcademy
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, List<double>>();

            for (int i = 1; i <= lines; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!list.ContainsKey(studentName))
                {
                    list.Add(studentName, new List<double>());
                }
                list[studentName].Add(grade);
            }
            foreach (var student in list.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {(student.Value.Average()):f2}");
                }
            }
        }
    }
}
