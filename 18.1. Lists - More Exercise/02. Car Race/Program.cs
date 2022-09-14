using System;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr  = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int time1 = 0;
            int time2 = 0;
            double reward1 = 0;
            double reward2 = 0;
            for (int i = 0; i < arr.Length/2; i++)
            {
                time1 += (int)arr[i];
                if (arr[i] == 0)
                    reward1 += time1 * 0.2;

                time2 += arr[arr.Length- 1 - i];
                if (arr[arr.Length - 1 - i] == 0)
                    reward2 += time2 * 0.2;
            }

            Console.WriteLine(time1 - reward1 < time2 - reward2
                ? $"The winner is left with total time: {time1 - reward1}"
                : $"The winner is right with total time: {time2 - reward2}");
        }
    }
}
