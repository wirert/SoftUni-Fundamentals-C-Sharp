using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern =
                @"([#|])(?<name>[\w\s]+)\1(?<expDate>[\d]{2}/[\d]{2}/[\d]{2})\1(?<calories>[\d]+)\1";

            var products = Regex.Matches(input, pattern);

            int totalCalories = 0;
            var listProducts = new List<Product>();

            foreach (Match product in products)
            {
                var name = product.Groups["name"].Value;
                var expDate = product.Groups["expDate"].Value;
                int calories = int.Parse(product.Groups["calories"].Value);

                totalCalories += calories;
                listProducts.Add(new Product(name, expDate, calories));
            }

            int daysWithFood = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysWithFood} days!");

            listProducts.ForEach(product => Console
                .WriteLine($"Item: {product.Name}, Best before: {product.Date}, Nutrition: {product.Calories}"));
        }
    }

    class Product
    {
        public Product(string name, string date, int calories)
        {
            this.Name = name;
            this.Date = date;
            this.Calories = calories;
        }

        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
    }
}
