using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);

                if (command[0] == "Shoot" && index >= 0 && index < targets.Count)
                    ShootTargets(targets, index, value);
                else if (command[0] == "Add")
                    AddTarget(targets, index, value);
                else if (command[0] == "Strike")
                    StrikeTargets(targets, index, value);

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join('|', targets));

        }

        private static List<int> StrikeTargets(List<int> targets, int index, int radius)
        {
            if (index < radius || index + radius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return targets;
            }
            targets.RemoveRange(index - radius, radius * 2 + 1);
            return targets;
        }

        private static List<int> AddTarget(List<int> targets, int index, int value)
        {
            if (index < 0 || index >= targets.Count)
            {
                Console.WriteLine("Invalid placement!");
                return targets;
            }
            targets.Insert(index, value);
            return targets;
        }

        private static List<int> ShootTargets(List<int> targets, int index, int power)
        {
            targets[index] -= power;
            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }

            return targets;
        }
    }
}
