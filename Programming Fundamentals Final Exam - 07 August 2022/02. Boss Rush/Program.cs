using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

            for (int i = 0; i < numInputs; i++)
            {
                string input = Console.ReadLine();

                var match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Access denied!");
                    continue;
                }

                Console.WriteLine($"{match.Groups["boss"].Value}, The {match.Groups["title"].Value}");
                Console.WriteLine($">> Strength: {match.Groups["boss"].Value.Length}");
                Console.WriteLine($">> Armor: {match.Groups["title"].Value.Length}");
            }

        }
    }
}
