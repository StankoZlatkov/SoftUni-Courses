using System;
using System.Collections.Generic;
using System.Linq;

namespace E10SoftUniExamResults
{
    class E10SoftUniExamResults
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var studentsListInfo = new Dictionary<string, Dictionary<string, int>>();

            while (input != "exam finished")
            {
                var userInfo = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string user = userInfo[0];
                string language = userInfo[1];
                double userGradeForLanguage = double.Parse(userInfo[2]);

                if (!studentsListInfo.ContainsKey(user))
                {
                    studentsListInfo.Add(user, new Dictionary<string, int>());
                }

                if (language == "banned")
                {
                }
                 //to do



                input = Console.ReadLine();
            }
        }
    }
}
