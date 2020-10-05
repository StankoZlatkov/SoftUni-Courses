using System;

namespace E01SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            sbyte firstPlayerTime = sbyte.Parse(Console.ReadLine());
            sbyte secondPlayerTime = sbyte.Parse(Console.ReadLine());
            sbyte thirdPlayerTime = sbyte.Parse(Console.ReadLine());


            int totalTime = firstPlayerTime + secondPlayerTime + thirdPlayerTime;

            int minutes = totalTime / 60;
            int secondsFirstDigit = (totalTime % 60 ) / 10;
            int secondsSecondDigit = (totalTime % 60) % 10;

            Console.WriteLine($"{minutes}:{secondsFirstDigit}{secondsSecondDigit}");
        }
    }
}
