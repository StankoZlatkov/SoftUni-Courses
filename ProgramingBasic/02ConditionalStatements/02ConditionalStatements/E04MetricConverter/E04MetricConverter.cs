namespace E04MetricConverter
{
    using System;

    class MetricConverter
    {
        static void Main()
        {
            double inputDistance = double.Parse(Console.ReadLine());
            string inputUnits = Console.ReadLine();
            string outputUnits = Console.ReadLine();

            double toMeter = 0;
            double outputDistance = 0;

            switch (inputUnits)
            {
                case "mm": 
                    toMeter = inputDistance / 1000;
                    break;
                case "cm":
                    toMeter = inputDistance / 100;
                    break;
                case "m":
                    toMeter = inputDistance / 1;
                    break;
            }
            switch (outputUnits)
            {
                case "mm":
                    outputDistance = toMeter * 1000;
                    break;
                case "cm":
                    outputDistance = toMeter * 100;
                    break;
                case "m":
                    outputDistance = toMeter * 1;
                    break;
            }

            Console.WriteLine($"{outputDistance:f3}");
        }
    }
}
