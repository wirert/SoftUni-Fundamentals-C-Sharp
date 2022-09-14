using System;
using System.Collections.Generic;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = null;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] action = command.Split(':');

                switch (action[0])
                {
                    case "Add Stop":
                        int index = int.Parse(action[1]);
                        string stopToAdd = action[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, stopToAdd);
                            
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(action[1]);
                        int endIndex = int.Parse(action[2]);

                        if (startIndex >= 0 && endIndex < stops.Length && startIndex <= endIndex)
                        {
                            stops = stops.Remove(startIndex, endIndex + 1 - startIndex);
                            
                        }
                        break;

                    case "Switch":
                        var oldString = action[1];
                        var newString = action[2];

                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                           
                        }

                        break;
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
