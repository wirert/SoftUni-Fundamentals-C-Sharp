using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numProducts; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
