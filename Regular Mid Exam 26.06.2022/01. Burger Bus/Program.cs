using System;

namespace _01._Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());

            double totalProfit = 0;

            for (int city = 1; city <= cities; city++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                double profit = 0;

                if (city % 3 == 0 && city % 5 == 0)
                {
                    profit = income * 0.9 - expenses;
                }
                else if (city % 3 == 0)
                {
                    profit = income - expenses * 1.5;
                }
                else if (city % 5 == 0)
                {
                    profit = income * 0.9 - expenses;
                }
                else
                {
                    profit = income - expenses;
                }

                totalProfit += profit;

                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
