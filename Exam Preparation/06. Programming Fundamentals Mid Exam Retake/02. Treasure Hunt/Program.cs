using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split('|').ToList();

            string[] loot = Console.ReadLine().Split();

            while (loot[0] != "Yohoho!")
            {
                switch (loot[0])
                {
                    case "Loot":
                        AddItemsInBegining(treasure, loot);
                        break;
                    case "Drop":
                        RemoveLootOfGivenPosition(treasure, loot);
                        break;
                    case "Steal":
                        RemoveNumberOfLootsFromEndAndPrintThem(treasure, loot);
                        break;

                }
                loot = Console.ReadLine().Split();
            }

            if (treasure.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }

            double avTreasure = 0;
            foreach (var item in treasure)
            {
                avTreasure += item.Length;
            }

            avTreasure /= treasure.Count;
            Console.WriteLine($"Average treasure gain: {avTreasure:f2} pirate credits.");
        }

        private static List<string> RemoveNumberOfLootsFromEndAndPrintThem(List<string> treasure, string[] steal)
        {
            int countItems = int.Parse(steal[1]);
            if (countItems >= treasure.Count)
            {
                Console.WriteLine(string.Join(", ", treasure));
                treasure.Clear();
                return treasure;
            }
            List<string> stealItems = new List<string>();
            for (int i = 1; i <= countItems; i++)
            {
                stealItems.Add(treasure[treasure.Count - 1 - countItems + i]);
                treasure.RemoveAt(treasure.Count - 1 - countItems + i);
            }

            Console.WriteLine(string.Join(", ", stealItems));
            return treasure;
        }

        private static List<string> RemoveLootOfGivenPosition(List<string> treasure, string[] drop)
        {
            int index = int.Parse(drop[1]);
            if (index < 0 || index >= treasure.Count - 1) return treasure;
            string item = treasure[index];
            treasure.RemoveAt(index);
            treasure.Add(item);
            return treasure;
        }

        private static List<string> AddItemsInBegining(List<string> treasure, string[] loot)
        {
            for (int i = 1; i < loot.Length; i++)
            {
                if (treasure.Contains(loot[i])) continue;
                treasure.Insert(0, loot[i]);
            }

            return treasure;
        }
    }
}
