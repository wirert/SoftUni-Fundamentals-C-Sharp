using System;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rout = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            foreach (var situation in rout)
            {
                string[] command = situation.Split(' ');

                switch (command[0])
                {
                    case "Travel":
                        int lightYears = int.Parse(command[1]);
                        if (fuel < lightYears)
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }

                        fuel -= lightYears;
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");

                        break;
                    case "Enemy":
                        int armour = int.Parse(command[1]);

                        if (ammunition >= armour)
                        {
                            ammunition -= armour;
                            Console.WriteLine($"An enemy with {armour} armour is defeated.");
                        }
                        else
                        {
                            if (fuel < armour * 2)
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }

                            fuel -= armour * 2;
                            Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
                        }

                        break;
                    case "Repair":
                        int amount = int.Parse(command[1]);

                        fuel += amount;
                        ammunition += amount * 2;

                        Console.WriteLine($"Ammunitions added: {amount * 2}.");
                        Console.WriteLine($"Fuel added: {amount}.");

                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");

                        return;
                }
            }
        }
    }
}
