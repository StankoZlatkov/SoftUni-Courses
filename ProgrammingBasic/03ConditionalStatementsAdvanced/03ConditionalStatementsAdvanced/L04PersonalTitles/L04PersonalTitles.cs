using System;

namespace L04PersonalTitles
{
    class PersonalTitles
    {
        static void Main()
        {
            float age = float.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            string title = string.Empty;

            if (gender == 'f')
            {
                if (age >= 16)
                {
                    title = "Ms.";
                }
                else
                {
                    title = "Miss";
                }
            }
            else if (gender == 'm')
            {
                if (age >= 16)
                {
                    title = "Mr.";
                }
                else
                {
                    title = "Master";
                }
            }

            Console.WriteLine(title);
        }
    }
}
