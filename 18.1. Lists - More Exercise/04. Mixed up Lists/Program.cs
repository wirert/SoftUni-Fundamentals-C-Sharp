using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixedList = new List<int>();
            List<int> borderList = new List<int>();

            int border = 0;
            bool isLongerList1 = list1.Count > list2.Count;

            border = isLongerList1 ? list2.Count : list1.Count;

            for (int i = 0; i < border; i++)
            {
                mixedList.Add(list1[i]);
                mixedList.Add(isLongerList1 ? list2[border - 1 - i] : list2[list2.Count - 1 - i]);
            }

            if (isLongerList1)
            {
                list1.RemoveRange(0, border);
                borderList = list1;
            }
            else
            {
                list2.RemoveRange(2, border);
                borderList = list2;
            }

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] <= Math.Min(borderList[0], borderList[1]) ||
                    mixedList[i] >= Math.Max(borderList[0], borderList[1]))
                {
                    mixedList.RemoveAt(i);
                    i--;
                }
            }
            mixedList.Sort();
            Console.WriteLine(string.Join(' ', mixedList));
        }
    }
}
