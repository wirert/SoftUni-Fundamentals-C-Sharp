using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] action = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                switch (action[0])
                {
                    case "Collect":
                        AddItemToInventory(inventory, action[1]);
                        break;
                    case "Drop":
                        RemoveItemFromInventory(inventory, action[1]);
                        break;
                    case "Combine Items":
                        AddNextToGivenItem(inventory, action[1]);
                        break;
                    case "Renew":
                        MoveToEndOfInventory(inventory, action[1]);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }

        private static List<string> MoveToEndOfInventory(List<string> inventory, string item)
        {
            if (!inventory.Contains(item)) return inventory;
            inventory.Remove(item);
            inventory.Add(item);
            return inventory;
        }

        private static List<string> AddNextToGivenItem(List<string> inventory, string s)
        {
            string[] items = s.Split(':', StringSplitOptions.RemoveEmptyEntries);

            if (!inventory.Contains(items[0])) return inventory;

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] != items[0]) continue;
                inventory.Insert(i + 1, items[1]);
                return inventory;
            }

            return inventory;
        }

        private static List<string> RemoveItemFromInventory(List<string> inventory, string item)
        {
            if (!inventory.Contains(item)) return inventory;
            inventory.Remove(item);
            return inventory;
        }

        private static List<string> AddItemToInventory(List<string> inventory, string item)
        {
            if (inventory.Contains(item)) return inventory;
            inventory.Add(item);
            return inventory;
        }
    }
}
