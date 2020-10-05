using System;

namespace E05TimePlus15Minutes
{
    class E05TimePlus15Minutes
    {
        static void Main()
        {
            int hoursInput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());

            int after15Minutes = (hoursInput * 60) + minutesInput + 15;
            int hoursOutput = (after15Minutes / 60) % 24;
            int minutesOutput = after15Minutes % 60;

            Console.WriteLine($"{hoursOutput}:{minutesOutput:D2}");
        }
    }
}
