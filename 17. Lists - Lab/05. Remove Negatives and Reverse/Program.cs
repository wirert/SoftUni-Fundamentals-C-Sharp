using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = intList.Count;

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] < 0)
                {
                    intList.RemoveAt(i);
                    i--;
                }
            }

            if (intList.Count == 0)
                Console.WriteLine("empty");

            intList.Reverse();
            Console.WriteLine(string.Join(' ', intList));

        }
    }
}
