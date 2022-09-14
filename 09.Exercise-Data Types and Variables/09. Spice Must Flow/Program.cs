using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int days = 0;
            int spiceCollected = 0;
            int currYield = startYield;
            while (currYield >= 100)
            {
                spiceCollected += currYield - 26;
                days++;
                currYield -= 10;
            }
            if (spiceCollected >= 26)
            {
                spiceCollected -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(spiceCollected);
        }
    }
}
