using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();

            int startCount = list1.Count > list2.Count ? list1.Count: list2.Count;

            for (int i = 0; i < startCount; i++)
            {
                if (list1.Count > i)
                    newList.Add(list1[i]);

                if (list2.Count > i)
                    newList.Add(list2[i]);
            }
            
            Console.WriteLine(string.Join(' ',newList));
        }
    }
}
