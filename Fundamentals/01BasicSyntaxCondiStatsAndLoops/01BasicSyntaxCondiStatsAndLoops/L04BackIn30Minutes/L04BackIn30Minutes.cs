using System;

namespace L04BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main()
        {
            int hoursInput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());

            int after30Minutes = (hoursInput * 60) + minutesInput + 30;
            int hoursOutput = (after30Minutes / 60) % 24;
            int minutesOutput = after30Minutes % 60;

            Console.WriteLine($"{hoursOutput}:{minutesOutput:D2}");
        }
    }
}
