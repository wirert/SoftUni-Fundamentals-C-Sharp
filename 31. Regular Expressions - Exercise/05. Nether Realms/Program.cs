using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-*/. ]";
            string damagePattern = @"-?\d+\.?\d*";
            string divideMultiplyPattern = @"[/*]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();

            foreach (var demon in demons)
            {
                double damage = 0;
                var healthMatch = Regex.Matches(demon, healthPattern);
                int health = 0;
                foreach (Match c in healthMatch)
                    health += char.Parse(c.Value);

                var matches = Regex.Matches(demon, damagePattern);

                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                var divideOrMultiplyMatches = Regex.Matches(demon, divideMultiplyPattern);

                foreach (Match match in divideOrMultiplyMatches)
                {
                    if (match.Value == "/")
                        damage /= 2;
                    else
                        damage *= 2;
                }

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage ");
            }
        }
    }
}