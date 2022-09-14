using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;

            string command = null;

            while ((command = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"%(?<customer>[A-Z][a-z]+)%[^$%\|\.]*<(?<product>[\w]+)>[^$%\|\.]*\|(?<count>\d+)\|[^$%\|\.1-9]*(?<price>\d+.?\d*)\$";

                var match = Regex.Match(command, pattern);

                if (!match.Success) continue;

                string customer = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                Console.WriteLine($"{customer}: {product} - {price * count:f2}");

                totalIncome += price * count;
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
