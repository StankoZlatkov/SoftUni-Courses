using System;

namespace L06ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA": Console.WriteLine("English"); break;
                case "Argentina":
                case "Mexico":
                case "Spain": Console.WriteLine("Spanish"); break;

                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
