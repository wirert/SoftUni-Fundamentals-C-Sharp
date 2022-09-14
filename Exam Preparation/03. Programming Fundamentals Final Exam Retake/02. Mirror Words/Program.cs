using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@#])(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";

            var matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }

            var validMatches = new List<string>();

            foreach (Match pairOfWords in matches)
            {
                string wordOne = pairOfWords.Groups["wordOne"].Value;
                string wordTwo = pairOfWords.Groups["wordTwo"].Value;

                if (wordOne == string.Join("", wordTwo.Reverse()))
                {
                    validMatches.Add($"{wordOne} <=> {wordTwo}");
                }
            }

            Console.WriteLine($"{matches.Count} word pairs found!");

            if (validMatches.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", validMatches));
            }
        }
    }
}
