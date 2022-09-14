using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstCards.Count != 0 && secondCards.Count != 0)
            {
                if (firstCards[0] == secondCards[0])
                {
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);
                }
                else if (firstCards[0] > secondCards[0])
                {
                    firstCards.Add(secondCards[0]);
                    firstCards.Add(firstCards[0]);
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);
                }
                else
                {
                    secondCards.Add(firstCards[0]);
                    secondCards.Add(secondCards[0]);
                    firstCards.RemoveAt(0);
                    secondCards.RemoveAt(0);
                }
            }

            PrintResult(firstCards, secondCards);
        }

        private static void PrintResult(List<int> firstCards, List<int> secondCards)
        {
            string winner = null;
            int sum = 0;
            if (firstCards.Count == 0)
            {
                winner = "Second";
                sum = secondCards.Sum();
            }
            else
            {
                winner = "First";
                sum = firstCards.Sum();
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
