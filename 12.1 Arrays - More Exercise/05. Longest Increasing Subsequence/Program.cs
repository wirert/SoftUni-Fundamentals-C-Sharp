using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> bestSequence = new List<int>();
            int bestIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                List<int> currSequence = new List<int>();
                currSequence.Add(arr[i]);
                int currBestindex = -1;
                int index = 0;
                for (int j = i; j >= 0; j--)
                {
                    if (currSequence[index] > arr[j])
                    {
                        currSequence.Add(arr[j]);
                        index++;
                        currBestindex = j;
                    }
                }

                if (currSequence.Count > bestSequence.Count)
                {
                    bestSequence = currSequence;
                    bestIndex = i;
                }
                else if (currSequence.Count == bestSequence.Count && currBestindex < bestIndex)
                {
                    bestSequence = currSequence;
                    currBestindex = bestIndex;
                }
            }

            bestSequence.Reverse();
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
