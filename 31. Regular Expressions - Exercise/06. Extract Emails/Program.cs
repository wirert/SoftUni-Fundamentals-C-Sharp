using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[A-Za-z0-9][\w\d.\-]*[A-Za-z0-9]@([A-Za-z][A-Za-z\-\.]+[A-Za-z]\.[A-Za-z]+)\b";

            string text = Console.ReadLine();

            var emails = Regex.Matches(text, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
