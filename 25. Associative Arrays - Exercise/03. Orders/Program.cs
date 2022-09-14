using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');

            var products = new Dictionary<string, Product>();

            while (command[0] != "buy")
            {
                string name = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Product()
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity
                    });
                }
                else
                {
                    if (products[name].Price == price)
                    {
                        products[name].Quantity += quantity;
                    }
                    else
                    {
                        products[name].Price = price;
                        products[name].Quantity += quantity;
                    }
                }

                command = Console.ReadLine().Split(' ');
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:f2}");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
