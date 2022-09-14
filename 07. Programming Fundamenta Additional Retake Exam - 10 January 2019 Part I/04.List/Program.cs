using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var giftsList = new Dictionary<string, int>();
            var goodChildren = new Dictionary<string, int>();

            string command = null;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] childInfo = command.Split("->");

                if (childInfo[0] == "Remove")
                {
                    goodChildren.Remove(childInfo[1]);
                    continue;
                }

                AddToysInPresentsList(childInfo, giftsList);

                AddKidInGoodKidsList(childInfo, goodChildren);
            }

            PrintTheListsOfGoodChildrenAndToys(goodChildren, giftsList);
        }

        private static void AddToysInPresentsList(string[] childInfo, Dictionary<string, int> giftsList)
        {
            string toyType = childInfo[1];
            int numToys = int.Parse(childInfo[2]);

            if (giftsList.ContainsKey(toyType))
            {
                giftsList[toyType] += numToys;
            }
            else
            {
                giftsList.Add(toyType, numToys);
            }
        }

        private static void AddKidInGoodKidsList(string[] childInfo, Dictionary<string, int> goodChildren)
        {
            string name = childInfo[0];
            int numToys = int.Parse(childInfo[2]);

            if (goodChildren.ContainsKey(name))
            {
                goodChildren[name] += numToys;
            }
            else
            {
                goodChildren.Add(name, numToys);
            }
        }

        private static void PrintTheListsOfGoodChildrenAndToys(Dictionary<string, int> goodChildren, Dictionary<string, int> giftsList)
        {
            Console.WriteLine("Children:");

            foreach (var child in goodChildren.OrderByDescending(child => child.Value).ThenBy(child => child.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var toy in giftsList)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}
