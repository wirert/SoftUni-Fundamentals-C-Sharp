using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0.0;
            while (command != "Start")
            {
                double currCoin = double.Parse(command);
                if (currCoin == 0.1 || currCoin == 0.2 || currCoin == 0.5 || currCoin == 1 || currCoin == 2)
                    money += currCoin;
                else
                    Console.WriteLine($"Cannot accept {currCoin}");
                command = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                double price = 0;
                if (product == "Nuts")
                    price = 2.0;
                else if (product == "Water")
                    price = 0.7;
                else if (product == "Crisps")
                    price = 1.5;
                else if (product == "Soda")
                    price = 0.8;
                else if (product == "Coke")
                    price = 1.0;
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }
                if (price <= money)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= price;
                }
                else
                    Console.WriteLine("Sorry, not enough money");
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
