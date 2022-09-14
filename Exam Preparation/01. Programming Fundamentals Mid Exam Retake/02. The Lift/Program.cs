using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < wagons.Length; i++)
            {
                for (int j = wagons[i]; j < 4; j++)
                {
                    if (passengers == 0)
                    {
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(' ', wagons));
                        return;
                    }

                    passengers--;
                    wagons[i]++;
                }
            }

            if (passengers > 0)
            {
                Console.WriteLine($"There isn't enough space! {passengers} people in a queue!");
            }

            Console.WriteLine(string.Join(' ', wagons));

        }
    }
}
