using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> qualityOfDrum = new List<int>();
            foreach (int num in drumSet)
            {
                qualityOfDrum.Add(num);
            }
            string command = null;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= hitPower)
                    {
                        if (savings < qualityOfDrum[i] * 3)
                        {
                            drumSet.RemoveAt(i);
                            qualityOfDrum.RemoveAt(i);
                            i--;
                            continue;
                        }
                        drumSet[i] = qualityOfDrum[i];
                        savings -= qualityOfDrum[i] * 3;
                    }
                    else
                        drumSet[i] -= hitPower;
                }
            }

            Console.WriteLine(string.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
