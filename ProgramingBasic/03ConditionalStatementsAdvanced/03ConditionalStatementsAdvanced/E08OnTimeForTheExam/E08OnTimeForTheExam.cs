using System;

namespace E08OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHours = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            string status = "";
            int examTime = (examHours * 60) + examMinutes;
            int arriveTime = (arriveHours * 60) + arriveMinutes;
            int differenceTime = examTime - arriveTime;

            if (differenceTime <= 30 && differenceTime >= 0)
            {
                status = "On time";
            }
            else if (differenceTime > 30)
            {
                status = "Early";
            }
            else if (arriveTime > examTime)
            {
                status = "Late";
            }

            Console.WriteLine(status);

            if (status == "On time")
            {
                int differenceMinutes = (examTime - arriveTime) % 60;

                if (differenceMinutes <= 9 && differenceMinutes > 0)
                {
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                }
                else if (differenceMinutes > 9)
                {
                    Console.WriteLine($"{differenceMinutes} minutes before the start");
                }
            }
            else if (status == "Late")
            {
                double lateTimeMinutes = (arriveTime - examTime) % 60;
                double lateTimeHours = (arriveTime - examTime) / 60;

                if (lateTimeHours < 1 && (lateTimeMinutes < 60 && lateTimeMinutes > 9))
                {
                    Console.WriteLine($"{lateTimeMinutes} minutes after the start");
                }
                else if (lateTimeHours < 1 && lateTimeMinutes <= 9)
                {
                    Console.WriteLine($"{lateTimeMinutes} minutes after the start");
                }
                else if (lateTimeHours >= 1 && (lateTimeMinutes < 60 && lateTimeMinutes > 9))
                {
                    Console.WriteLine($"{lateTimeHours}:{lateTimeMinutes} hours after the start");
                }
                else if (lateTimeHours >= 1 && lateTimeMinutes <= 9)
                {
                    Console.WriteLine($"{lateTimeHours}:0{lateTimeMinutes} hours after the start");
                }
            }
            else if (status == "Early")
            {
                double earlyMinutes = differenceTime % 60;
                double earlyTimeHours = differenceTime / 60;

                if (earlyTimeHours < 1 && (earlyMinutes < 60 && earlyMinutes > 9))
                {
                    Console.WriteLine($"{earlyMinutes} minutes before the start");
                }
                else if (earlyTimeHours < 1 && earlyMinutes <= 9)
                {
                    Console.WriteLine($"{earlyMinutes} minutes before the start");
                }
                else if (earlyTimeHours >= 1 && (earlyMinutes < 60 && earlyMinutes > 9))
                {
                    Console.WriteLine($"{earlyTimeHours}:{earlyMinutes} hours before the start");
                }
                else if (earlyTimeHours >= 1 && (earlyMinutes < 60 && earlyMinutes <= 9))
                {
                    Console.WriteLine($"{earlyTimeHours}:0{earlyMinutes} hours before the start");
                }
            }  
        } 
    }
}
