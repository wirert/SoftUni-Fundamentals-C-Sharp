using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var firstPart = input[0];
            var secondPart = input[1];
            var thirdPart = input[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var firstLetters = ConvertTheInputWithRegex(firstPart, secondPart, out var secondPartMatches);

            var wordInfo = new Dictionary<char, List<int>>();
            
            FindValidCodeToExtractMessages(secondPartMatches, firstLetters, wordInfo);

            PrintTheValidMessages(thirdPart, wordInfo);
        }

        private static string ConvertTheInputWithRegex(string firstPart, string secondPart,
            out MatchCollection secondPartMatches)
        {
            string firstPattern = @"([#$%*&])(?<capitalLetters>[A-Z]+)\1";
            var firstLetters = Regex.Match(firstPart, firstPattern).Groups["capitalLetters"].Value;

            string secondPartPattern = @"([\d]{2}):([\d]{2})";
            secondPartMatches = Regex.Matches(secondPart, secondPartPattern);
            return firstLetters;
        }

        private static void FindValidCodeToExtractMessages(MatchCollection secondPartMatches, string firstLetters,
            Dictionary<char, List<int>> wordInfo)
        {
            for (var index = 0; index < secondPartMatches.Count; index++)
            {
                Match currMatch = secondPartMatches[index];
                char capitalLetter = (char)(int.Parse(currMatch.Groups[1].Value));

                if (!firstLetters.Contains(capitalLetter)) continue;

                int numLetters = int.Parse(currMatch.Groups[2].Value);

                if (numLetters < 1 && numLetters > 20) continue;

                if (!wordInfo.ContainsKey(capitalLetter))
                {
                    wordInfo.Add(capitalLetter, new List<int>());
                }

                if (wordInfo[capitalLetter].Any(x => x == numLetters)) continue;

                wordInfo[capitalLetter].Add(numLetters);
            }
        }

        private static void PrintTheValidMessages(string[] thirdPart, Dictionary<char, List<int>> wordInfo)
        {
            foreach (var word in thirdPart)
            {
                if (!wordInfo.ContainsKey(word[0])) continue;

                if (wordInfo[word[0]].All(wordLength => wordLength != word.Length - 1)) continue;

                Console.WriteLine(word);
            }
        }
    }
}
