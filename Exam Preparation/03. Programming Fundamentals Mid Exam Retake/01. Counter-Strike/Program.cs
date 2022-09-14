using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = null;
            int battleCount = 0;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy >= distance)
                {
                    energy -= distance;
                    battleCount++;
                    if (battleCount % 3 == 0)
                    {
                        energy += battleCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleCount} won battles and {energy} energy");
                    return;
                }

            }

            Console.WriteLine($"Won battles: {battleCount}. Energy left: {energy}");
        }
    }
}
