using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            
            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach (Match name in matches)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
