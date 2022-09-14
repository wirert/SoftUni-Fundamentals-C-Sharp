using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            float currBalance = budget;
            string command = null;
            while ((command = Console.ReadLine()) != "Game Time")
            {
                float gamePrice = 0;

                switch (command)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99f;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99f;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99f;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99f;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99f;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (currBalance > gamePrice)
                {
                    Console.WriteLine($"Bought {command}");
                    currBalance -= gamePrice;
                }
                else if (currBalance == gamePrice)
                {
                    Console.WriteLine($"Bought {command}");
                    Console.WriteLine("Out of money!");
                    return;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

            }
            Console.WriteLine($"Total spent: ${budget - currBalance:f2}. Remaining: ${currBalance:f2}");
        }
    }
}
        
