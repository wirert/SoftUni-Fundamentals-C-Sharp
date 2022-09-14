using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double targetPlunder = double.Parse(Console.ReadLine());

            double plunder = 0;

            for (int day = 1; day <= days; day++)
            {
                plunder += dailyPlunder;
                if (day % 3 == 0)
                    plunder += dailyPlunder * 0.5;
                if (day % 5 == 0)
                    plunder -= plunder * 3 / 10;
            }

            Console.WriteLine(plunder >= targetPlunder
                ? $"Ahoy! {plunder:f2} plunder gained."
                : $"Collected only {plunder * 100 / targetPlunder:f2}% of the plunder.");
        }
    }
}
