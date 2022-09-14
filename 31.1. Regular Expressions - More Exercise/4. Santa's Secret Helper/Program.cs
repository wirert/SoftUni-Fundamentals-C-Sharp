using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numToSubtract = int.Parse(Console.ReadLine());

            string command = null;

            while ((command = Console.ReadLine()) != "end")
            {
                string text = command
                    .Aggregate<char, string>(null, (current, symbol) => current + (char)(symbol - numToSubtract));

                string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behave>[GN])!";

                Match match = Regex.Match(text, pattern);

                if (!match.Success) continue;

                if (match.Groups["behave"].Value == "G")
                    Console.WriteLine(match.Groups["name"].Value);
            }
        }
    }
}
