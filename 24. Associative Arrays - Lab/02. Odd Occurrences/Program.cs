using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                .Split(' ')
                .Select(word => word.ToLower())
                .ToArray();

            var wordOccurrences = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (!wordOccurrences.ContainsKey(word))
                {
                    wordOccurrences.Add(word, 0);
                }

                wordOccurrences[word]++;
            }

            foreach (var word in wordOccurrences)
            {
                if (word.Value % 2 != 0)
                    Console.Write($"{word.Key} ");
            }
        }
    }
}
