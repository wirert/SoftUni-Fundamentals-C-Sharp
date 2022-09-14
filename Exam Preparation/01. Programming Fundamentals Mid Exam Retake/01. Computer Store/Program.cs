using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;
            while (command != "special" && command != "regular")
            {
                double currPrice = double.Parse(command);
                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                taxes += currPrice / 5;
                totalPrice += currPrice;

                command = Console.ReadLine();
            }

            PrintReceipt(command, taxes, totalPrice);
        }

        private static void PrintReceipt(string command, double taxes, double totalPrice)
        {
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double priceWithTaxes = totalPrice + taxes;
            if (command == "special")
            {
                priceWithTaxes *= 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
        }
    }
}
