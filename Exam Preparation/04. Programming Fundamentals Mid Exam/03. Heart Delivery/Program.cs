using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();

            int houseIndex = 0;

            while (command[0] != "Love!")
            {
                int jump = int.Parse(command[1]);

                if (houseIndex + jump > houses.Length - 1)
                    houseIndex = 0;
                else
                    houseIndex += jump;

                if (houses[houseIndex] == 0)
                    Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                else
                {
                    houses[houseIndex] -= 2;
                    if (houses[houseIndex] == 0)
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {houseIndex}.");

            bool isMissionSuccessful = true;
            int countFailed = 0;

            foreach (var house in houses)
            {
                if (house == 0) continue;
                isMissionSuccessful = false;
                countFailed++;
            }

            Console.WriteLine(isMissionSuccessful
                ? "Mission was successful."
                : $"Cupid has failed {countFailed} places.");
        }
    }
}
