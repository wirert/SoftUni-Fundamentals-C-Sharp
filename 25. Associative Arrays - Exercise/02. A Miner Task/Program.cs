using System;
using System.Collections.Generic;
using System.Threading;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count = 0;
            string curResource = null;
            var resources = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                count++;
                if (count % 2 != 0)
                {
                    curResource = input;
                    if (resources.ContainsKey(input))
                        continue;
                    resources.Add(input, 0);
                }
                else
                {
                    int quantity = int.Parse(input);
                    resources[curResource] += quantity;
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
