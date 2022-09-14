using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                    DeleteElementsInList(intList, command);
                else
                    InsertInGivenPosition(intList, command);

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', intList));
        }

        private static List<int> InsertInGivenPosition(List<int> intList, string[] command)
        {
            intList.Insert(int.Parse(command[2]), int.Parse(command[1]));
            return intList;
        }

        private static List<int> DeleteElementsInList(List<int> intList, string[] command)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == int.Parse(command[1]))
                {
                    intList.RemoveAt(i);
                    i--;
                }
            }
            return intList;
        }
    }
}
