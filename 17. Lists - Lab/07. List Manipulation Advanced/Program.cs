using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();
            bool isListChanged = false;

            while (command[0] != "end")
            {

                switch (command[0])
                {
                    case "Add":
                        AddCommand(intList, command);
                        isListChanged = true;
                        break;
                    case "Remove":
                        RemoveCommand(intList, command);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        RemoveAtCommand(intList, command);
                        isListChanged = true;
                        break;
                    case "Insert":
                        InsertCommand(intList, command);
                        isListChanged = true;
                        break;
                    case "Contains":
                        PrintIfContainsInList(intList, command);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(intList);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(intList);
                        break;
                    case "GetSum":
                        PrintGetSumOfList(intList);
                        break;
                    case "Filter":
                        PrintFilteredList(intList, command);
                        break;

                }

                command = Console.ReadLine().Split();
            }

            if (isListChanged)
                Console.WriteLine(string.Join(' ', intList));
        }

        private static void PrintFilteredList(List<int> intList, string[] command)
        {

            switch (command[1])
            {
                case "<":
                    foreach (int num in intList)
                    {
                        if (num < int.Parse(command[2]))
                            Console.Write($"{num} ");
                    }

                    Console.WriteLine();
                    break;
                case ">":
                    foreach (int num in intList)
                    {
                        if (num > int.Parse(command[2]))
                            Console.Write($"{num} ");
                    }

                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (int num in intList)
                    {
                        if (num >= int.Parse(command[2]))
                            Console.Write($"{num} ");
                    }

                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (int num in intList)
                    {
                        if (num <= int.Parse(command[2]))
                            Console.Write($"{num} ");
                    }

                    Console.WriteLine();
                    break;
            }

        }

        private static void PrintGetSumOfList(List<int> intList)
        {
            Console.WriteLine(intList.Sum());
        }

        private static void PrintOddNumbers(List<int> intList)
        {
            foreach (int number in intList)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.WriteLine();
        }

        private static void PrintEvenNumbers(List<int> intList)
        {
            foreach (int number in intList)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.WriteLine();
        }

        private static void PrintIfContainsInList(List<int> intList, string[] command)
        {
            Console.WriteLine(intList.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
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
