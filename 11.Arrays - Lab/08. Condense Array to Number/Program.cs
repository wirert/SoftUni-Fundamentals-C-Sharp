using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[initialArr.Length - 1];
            while (condensed.Length > 0)
            {
                for (int i = 0; i < initialArr.Length - 1; i++)
                {
                    condensed[i] = initialArr[i] + initialArr[i + 1];
                }
                initialArr = condensed;
                condensed = new int[initialArr.Length - 1];
            }
            Console.WriteLine(string.Join(' ', initialArr));
        }
    }
}
