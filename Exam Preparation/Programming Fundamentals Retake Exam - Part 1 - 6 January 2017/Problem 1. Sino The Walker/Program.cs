using System;
using System.Numerics;

namespace Problem_1._Sino_The_Walker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputTime = Console.ReadLine().Split(':');
            int hour = int.Parse(inputTime[0]);
            int minute = int.Parse(inputTime[1]);
            int second = int.Parse(inputTime[2]);

            DateTime time = new DateTime(2022, 07, 20, hour, minute, second);

            int steps = int.Parse(Console.ReadLine());
            int secondsForStep = int.Parse(Console.ReadLine());

            double minutesToAdd = steps * secondsForStep;

            time = time.AddSeconds(minutesToAdd);

            Console.WriteLine($"Time Arrival: {time:HH:mm:ss}");
        }
    }
}
