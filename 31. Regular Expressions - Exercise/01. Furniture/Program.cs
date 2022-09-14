using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>[0-9]+(.?[0-9]+)?)!(?<quantity>[0-9]+)";

            double moneySpend = 0;
            List<string> furnitures = new List<string>();
            string command = null;

            while ((command = Console.ReadLine()) != "Purchase")
            {
                var purchise = Regex.Match(command, pattern, RegexOptions.IgnoreCase);

                if (!purchise.Success) continue;

                double price = double.Parse(purchise.Groups["price"].Value);
                int quantity = int.Parse(purchise.Groups["quantity"].Value);

                furnitures.Add(purchise.Groups["name"].Value);
                moneySpend += price * quantity;

            }

            Console.WriteLine("Bought furniture:");
            furnitures.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
