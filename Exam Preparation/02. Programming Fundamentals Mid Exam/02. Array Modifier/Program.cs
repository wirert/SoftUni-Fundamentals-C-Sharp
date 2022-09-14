using System;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "swap")
                    SwapElements(arr, command);

                else if (command[0] == "multiply")
                    MultiplyElements(arr, command);

                else
                    DecreaseElements(arr, command);


                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DecreaseElements(int[] arr, string[] command)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }

        private static void MultiplyElements(int[] arr, string[] command)
        {
            int index1 = int.Parse(command[1]);
            int index2 = int.Parse(command[2]);
            arr[index1] *= arr[index2];
        }

        private static int[] SwapElements(int[] arr, string[] command)
        {
            int index1 = int.Parse(command[1]);
            int index2 = int.Parse(command[2]);
            (arr[index1], arr[index2]) = (arr[index2], arr[index1]);
            return arr;
        }
    }
}
