using System;

namespace _01._Santa_s_Cookies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 1; i <= batches; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;

                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                int cookiesPerBake = (int)Math.Floor(170.0 * Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) / 25);

                int boxesPerBatch = cookiesPerBake / 5;

                Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");

                totalBoxes += boxesPerBatch;
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}