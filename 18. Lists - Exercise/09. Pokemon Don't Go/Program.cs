using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokeDist = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumOfRemovedElements = 0;


            while (pokeDist.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int remElement = 0;
                if (index < 0)
                {
                    remElement = pokeDist[0];
                    pokeDist[0] = pokeDist[pokeDist.Count - 1];
                }
                else if (index >= pokeDist.Count)
                {
                    remElement = pokeDist[pokeDist.Count - 1];
                    pokeDist[pokeDist.Count - 1] = pokeDist[0];
                }
                else
                {
                    remElement = pokeDist[index];
                    pokeDist.RemoveAt(index);
                }

                sumOfRemovedElements += remElement;

                for (int i = 0; i < pokeDist.Count; i++)
                {
                    if (pokeDist[i] <= remElement)
                    {
                        pokeDist[i] += remElement;
                    }
                    else
                    {
                        pokeDist[i] -= remElement;
                    }
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        private static void DefineIndexRange(List<int> pokeDist, int index, int remElement, int sum)
        {

        }
    }
}
