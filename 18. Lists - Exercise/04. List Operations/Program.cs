using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (index >= list.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.Insert(index, int.Parse(command[1]));
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(command[1]);
                        if (removeIndex >= list.Count || removeIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.RemoveAt(removeIndex);
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                list.Add(list[0]);
                                list.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                list.Insert(0, list[list.Count - 1]);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
