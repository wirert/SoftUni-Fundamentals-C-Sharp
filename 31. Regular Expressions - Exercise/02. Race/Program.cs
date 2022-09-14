using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> raceList = new Dictionary<string, int>();
            string command = null;

            while ((command = Console.ReadLine()) != "end of race")
            {
                var nameChars = Regex.Matches(command, @"[A-Za-z]");
                string name = string.Join("", nameChars);

                if (!participants.Contains(name)) continue;

                var distance = Regex.Matches(command, @"[0-9]");
                int dist = 0;
                foreach (Match ch in distance)
                {
                    dist += int.Parse(ch.ToString());
                }

                if (!raceList.ContainsKey(name))
                    raceList.Add(name, dist);
                else
                    raceList[name] += dist;
            }

            var winnerList = raceList.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);
            string first = winnerList.First().Key;
            string third = winnerList.Last().Key;
            string second = winnerList.Take(2).OrderBy(x => x.Value).First().Key;

            Console.WriteLine($"1st place: {first}");
            Console.WriteLine($"2nd place: {second}");
            Console.WriteLine($"3rd place: {third}");
        }
    }
}
