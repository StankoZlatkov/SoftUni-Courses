using System;
using System.Collections.Generic;
using System.Linq;

namespace E08CompanyUsers
{
    class CompanyUsers
    {
        static void Main()
        {
            var list = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] array = input.Split(" -> ").ToArray();
                string company = array[0];
                string user = array[1];

                if (!list.ContainsKey(company))
                {
                    list.Add(company, new List<string>());
                }
                if (!list[company].Contains(user))
                {
                    list[company].Add(user);
                }
            }
            foreach (var company in list.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var user in company.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
