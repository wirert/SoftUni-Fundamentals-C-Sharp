using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string winningPattern = @"([@#$^])\1{5,8}";
            string jackpotPattern = @"([@#$^])\1{19}";

            var tickets = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currTicket in tickets)
            {
                var ticket = currTicket.Trim();
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (Regex.IsMatch(ticket, jackpotPattern))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[1]} Jackpot!");
                    continue;
                }

                var leftSide = String.Join("", ticket.Take(10));
                var rightSide = String.Join("", ticket.Skip(10));
                var leftMatch = Regex.Match(leftSide, winningPattern);
                var rightMatch = Regex.Match(rightSide, winningPattern);

                if (!leftMatch.Success || !rightMatch.Success || leftMatch.Groups[1].Value != rightMatch.Groups[1].Value)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else
                {
                    var symbol = leftMatch.Groups[1].Value;
                    var length = Math.Min(leftMatch.Groups[0].Length, rightMatch.Groups[0].Length);
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                }
            }
        }
    }
}
