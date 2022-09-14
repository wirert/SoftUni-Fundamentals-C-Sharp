using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int currHouseIndex = 0;

            for (int i = 1; i <= numCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Forward":
                        currHouseIndex = ForwardToHouse(command, currHouseIndex, houses);
                        break;
                    case "Back":
                        currHouseIndex = BackToHouse(command, currHouseIndex, houses);
                        break;
                    case "Gift":
                        currHouseIndex = GiftToHouse(command, currHouseIndex, houses);
                        break;
                    case "Swap":
                        SwapHouses(command, houses);
                        break;
                }
            }

            Console.WriteLine($"Position: {currHouseIndex}");
            Console.WriteLine(string.Join(", ", houses));
        }

        private static void SwapHouses(string[] command, List<int> houses)
        {
            int house1 = int.Parse(command[1]);
            int house2 = int.Parse(command[2]);

            if (!houses.Contains(house1) || !houses.Contains(house2)) return;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] == house1)
                    houses[i] = house2;
                else if (houses[i] == house2)
                    houses[i] = house1;
            }
        }

        static int GiftToHouse(string[] command, int position, List<int> houses)
        {
            int index = int.Parse(command[1]);
            if (index < 0 || index >= houses.Count) return position;

            houses.Insert(index, int.Parse(command[2]));
            position = index;

            return position;
        }
        static int BackToHouse(string[] command, int position, List<int> houses)
        {
            int steps = int.Parse(command[1]);
            if (position - steps < 0) return position;
            position -= steps;
            houses.RemoveAt(position);

            return position;
        }
        static int ForwardToHouse(string[] command, int house, List<int> houses)
        {
            int steps = int.Parse(command[1]);
            if (house + steps >= houses.Count) return house;
            house += steps;
            houses.RemoveAt(house);

            return house;
        }
    }
}
