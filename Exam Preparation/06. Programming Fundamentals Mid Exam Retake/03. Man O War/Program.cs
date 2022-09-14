using System;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int maxHealth = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "Retire")
            {
                switch (command[0])
                {
                    case "Fire":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >= warShip.Length)
                        {
                            command = Console.ReadLine().Split(' ');
                            continue;
                        }

                        warShip[index] -= int.Parse(command[2]);
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }

                        break;
                    case "Defend":
                        AttackAtPirateship(pirateShip, command);
                        if (pirateShip.Any(section => section <= 0))
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                        break;
                    case "Repair":
                        RepairSectionOfPirateship(pirateShip, command, maxHealth);
                        break;
                    case "Status":
                        PrintStatusOfPirateship(pirateShip, maxHealth);
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");

        }

        private static void PrintStatusOfPirateship(int[] ship, int maxHealth)
        {
            int count = ship.Count(section => section < Math.Ceiling((double)(maxHealth) / 5));
            Console.WriteLine($"{count} sections need repair.");
        }

        private static int[] RepairSectionOfPirateship(int[] pirateShip, string[] command, int maxHealth)
        {
            int index = int.Parse(command[1]);
            if (index < 0 || index >= pirateShip.Length) return pirateShip;

            int health = int.Parse(command[2]);
            pirateShip[index] += health;
            if (pirateShip[index] < maxHealth) return pirateShip;
            pirateShip[index] = maxHealth;
            return pirateShip;
        }

        private static int[] AttackAtPirateship(int[] pirateShip, string[] command)
        {
            int start = Math.Min(int.Parse(command[1]), int.Parse(command[2]));
            int end = Math.Max(int.Parse(command[1]), int.Parse(command[2]));
            if (start < 0 || end >= pirateShip.Length) return pirateShip;

            for (int i = start; i <= end; i++)
            {
                pirateShip[i] -= int.Parse(command[3]);
            }

            return pirateShip;
        }
    }
}
