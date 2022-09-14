using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})([.\-/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();

            MatchCollection dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
