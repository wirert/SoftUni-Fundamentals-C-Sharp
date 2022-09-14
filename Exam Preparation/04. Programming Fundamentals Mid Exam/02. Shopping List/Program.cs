using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Go")
            {
                switch (command[0])
                {
                    case "Urgent":
                        UrgentProduct(groceries, command);
                        break;
                    case "Unnecessary":
                        UnnecessaryProduct(groceries, command);
                        break;
                    case "Correct":
                        CorrectProduct(groceries, command);
                        break;
                    default:
                        RearrangeProducts(groceries, command);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }

        private static List<string> RearrangeProducts(List<string> groceries, string[] command)
        {
            if (!groceries.Contains(command[1])) return groceries;
            groceries.Remove(command[1]);
            groceries.Add(command[1]);
            return groceries;
        }

        private static List<string> CorrectProduct(List<string> groceries, string[] command)
        {
            if (!groceries.Contains(command[1])) return groceries;

            for (int i = 0; i < groceries.Count; i++)
            {
                if (groceries[i] == command[1])
                    groceries[i] = command[2];
            }
            // groceries = groceries.Select(x => x.Replace(command[1], command[2])).ToList();
            return groceries;
        }

        private static List<string> UnnecessaryProduct(List<string> groceries, string[] command)
        {
            if (!groceries.Contains(command[1])) return groceries;
            groceries.Remove(command[1]);
            return groceries;
        }

        private static List<string> UrgentProduct(List<string> groceries, string[] command)
        {
            if (groceries.Contains(command[1])) return groceries;
            groceries.Insert(0, command[1]);
            return groceries;
        }
    }
}
