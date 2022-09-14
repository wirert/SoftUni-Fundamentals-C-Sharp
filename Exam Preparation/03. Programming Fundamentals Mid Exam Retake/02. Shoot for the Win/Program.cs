using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = null;
            int count = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(command);
                if (targetIndex < 0 || targetIndex >= targets.Length || targets[targetIndex] == -1)
                {
                    continue;
                }

                count++;

                ChangeTargetsValue(targets, targetIndex);

            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");
        }

        private static int[] ChangeTargetsValue(int[] targets, int targetIndex)
        {
            int currTarget = targets[targetIndex];
            targets[targetIndex] = -1;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }

                if (targets[i] > currTarget)
                {
                    targets[i] -= currTarget;
                }
                else
                {
                    targets[i] += currTarget;
                }
            }
            return targets;
        }
    }
}
