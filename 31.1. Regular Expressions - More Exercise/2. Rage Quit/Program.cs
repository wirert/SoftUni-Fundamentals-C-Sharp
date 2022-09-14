using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = @"([\D]+)([\d]+)";

            var matches = Regex.Matches(input, pattern);
            StringBuilder resultText = new StringBuilder();
            var listChars = new List<char>();

            foreach (Match match in matches)
            {
                int digit = int.Parse(match.Groups[2].Value);
                string textToRepeat = match.Groups[1].Value;

                for (int i = 1; i <= digit; i++)
                {
                    resultText.Append(textToRepeat);
                }

            }

            foreach (var symbol in resultText.ToString().Where(symbol => !listChars.Contains(symbol)))
            {
                listChars.Add(symbol);
            }

            Console.WriteLine($"Unique symbols used: {listChars.Count}");
            Console.WriteLine(resultText);
        }
    }
}
