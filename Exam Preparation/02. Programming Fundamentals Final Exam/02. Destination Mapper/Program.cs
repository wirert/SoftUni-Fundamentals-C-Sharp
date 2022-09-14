using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([=/])(?<destination>[A-Z][A-Za-z]{2,})\1";

            var destinations = Regex.Matches(input, pattern);

            int travelPoints = 0;

            var dest = new List<string>();

            foreach (Match destination in destinations)
            {
                travelPoints += destination.Groups["destination"].Value.Length;
                dest.Add(destination.Groups["destination"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", dest)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
