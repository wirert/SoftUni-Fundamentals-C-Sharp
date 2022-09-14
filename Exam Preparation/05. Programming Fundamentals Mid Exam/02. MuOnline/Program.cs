using System;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currRoom = rooms[i].Split(' ');

                switch (currRoom[0])
                {
                    case "potion":
                        int heal = int.Parse(currRoom[1]);
                        if (health + heal <= 100)
                        {
                            health += heal;
                            Console.WriteLine($"You healed for {heal} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {100 - health} hp.");
                            Console.WriteLine("Current health: 100 hp.");
                            health = 100;
                        }
                        break;
                    case "chest":
                        bitcoins += int.Parse(currRoom[1]);
                        Console.WriteLine($"You found {currRoom[1]} bitcoins.");
                        break;
                    default:
                        int points = int.Parse(currRoom[1]);
                        if (health > points)
                        {
                            health -= points;
                            Console.WriteLine($"You slayed {currRoom[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {currRoom[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }

                        break;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
