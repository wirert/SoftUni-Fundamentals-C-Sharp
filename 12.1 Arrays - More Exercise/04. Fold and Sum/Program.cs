using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrReversed = new int[arr.Length/2];
            int index = 0;
            for (int i = arr.Length/4 - 1; i >= 0; i--)
            {
                arrReversed[index] = arr[i];
                index++;
            }

            for (int i = arr.Length - 1; i >= arr.Length - arr.Length / 4; i--)
            {
                arrReversed[index] = arr[i];
                index++;
            }

            int[] arrSplit = new int[arr.Length / 2];
            index = 0;
            for (int i = arr.Length / 4; i < arr.Length - arr.Length / 4; i++)
            {
                arrSplit[index] = arr[i];
                index++;
            }

            int[] sumArr = new int[arrSplit.Length];
            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = arrSplit[i] + arrReversed[i];
            }

            Console.WriteLine(string.Join(' ', sumArr));
        }
    }
}
