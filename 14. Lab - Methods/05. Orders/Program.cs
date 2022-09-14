using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{ProductPrice(product) * quantity:f2}");
        }

        static double ProductPrice(string product)
        {
            switch (product)
            {
                case "coffee": return 1.50;
                case "water": return 1.00;
                case "coke": return 1.40;
                default: return 2.00;
            }
        }

    }
}
