using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                string pattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";

                if (!Regex.IsMatch(barcode, pattern))
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string group = null;

                foreach (var symbol in barcode)
                {
                    if (char.IsDigit(symbol))
                        group += symbol;
                }

                Console.WriteLine(group == null ? "Product group: 00" : $"Product group: {group}");
            }
        }
    }
}
