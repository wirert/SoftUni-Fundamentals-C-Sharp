using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = null;
            int count = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                count++;
                int[] indexes = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (IsNonValid(elements, indexes, count))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                if (elements[indexes[0]] == elements[indexes[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[indexes[0]]}!");
                    if (indexes[0] > indexes[1])
                    {
                        elements.RemoveAt(indexes[0]);
                        elements.RemoveAt(indexes[1]);
                    }
                    else
                    {
                        elements.RemoveAt(indexes[1]);
                        elements.RemoveAt(indexes[0]);
                    }

                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (!elements.Any())
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }

        private static bool IsNonValid(List<string> elements, int[] indexes, int count)
        {
            if (indexes[0] == indexes[1] || indexes[0] < 0 || indexes[1] < 0 || indexes[0] > elements.Count - 1 || indexes[1] > elements.Count - 1)
            {
                elements.Insert(elements.Count / 2, -count + "a");
                elements.Insert(elements.Count / 2, -count + "a");
                return true;
            }

            return false;
        }
    }
}
