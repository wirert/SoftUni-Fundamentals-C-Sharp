using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "Add":
                        AddCommand(intList, command);
                        break;
                    case "Remove":
                        RemoveCommand(intList, command);
                        break;
                    case "RemoveAt":
                        RemoveAtCommand(intList, command);
                        break;
                    case "Insert":
                        InsertCommand(intList, command);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', intList));
        }

        private static List<int> AddCommand(List<int> intList, string[] command)
        {
            intList.Add(int.Parse(command[1]));
            return intList;
        }

        private static List<int> RemoveCommand(List<int> intList, string[] command)
        {
            intList.Remove(int.Parse(command[1]));
            return intList;
        }

        private static List<int> RemoveAtCommand(List<int> intList, string[] command)
        {
            intList.RemoveAt(int.Parse(command[1]));
            return intList;
        }

        private static List<int> InsertCommand(List<int> intList, string[] command)
        {
            intList.Insert(int.Parse(command[2]), int.Parse(command[1]));
            return intList;
        }
    }
}
