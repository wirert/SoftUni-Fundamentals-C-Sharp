using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMessages = int.Parse(Console.ReadLine());

            List<string> attackPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numMessages; i++)
            {
                string message = Console.ReadLine();

                int count = message.ToLower()
                    .Count(symbol => symbol == 's' || symbol == 't' || symbol == 'a' || symbol == 'r');

                string decodedMessage = message.Aggregate<char, string>(null, (current, symbol) => current + (char)(symbol - count));

                string pattern =
                    @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(\d+)";

                var match = Regex.Match(decodedMessage, pattern);
                string planetName = match.Groups["planet"].Value;
                var attackType = match.Groups["type"].Value;

                if (!match.Success) continue;

                if (attackType == "A")
                    attackPlanets.Add(planetName);
                else
                    destroyedPlanets.Add(planetName);
            }

            Console.WriteLine($"Attacked planets: {attackPlanets.Count}");
            foreach (var attackPlanet in attackPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {attackPlanet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }
    }
}
