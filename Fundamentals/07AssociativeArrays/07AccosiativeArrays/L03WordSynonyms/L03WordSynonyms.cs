using System;
using System.Collections.Generic;

namespace L03WordSynonyms
{
    class WordSynonyms
    {
        static void Main()
        {
            int words = int.Parse(Console.ReadLine());

            var synonymsList = new Dictionary<string, List<string>>();

            for (int i = 1; i <= words; i++)
            {
                string baseWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymsList.ContainsKey(baseWord))
                {
                    synonymsList.Add(baseWord, new List<string>());
                }
                synonymsList[baseWord].Add(synonym);
            }

            foreach (var word in synonymsList)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
