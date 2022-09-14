using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());

            List<string> gestList = new List<string>();

            for (int i = 0; i < numCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string name = command[0];

                if (command[2] != "not")
                {
                    if (gestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    gestList.Add(name);
                }
                else
                {
                    if (!gestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    gestList.Remove(name);
                }

            }

            foreach (var gest in gestList)
            {
                Console.WriteLine(gest);
            }
        }
    }
}
