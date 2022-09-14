using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> persons = new List<Person>();

            foreach (var str in peopleInput)
            {
                string[] pers = str.Split('=', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(pers[0], double.Parse(pers[1]));
                persons.Add(person);
            }

            List<Product> products = new List<Product>();

            foreach (var str in productsInput)
            {
                string[] prodSplit = str.Split('=', StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(prodSplit[0], double.Parse(prodSplit[1]));
                products.Add(product);
            }

            string command = null;

            while ((command = Console.ReadLine()) != "END")
            {
                string personBuyProduct = command.Split()[0];
                string productToBuy = command.Split()[1];

                Person curPerson = persons.Find(person => person.Name == personBuyProduct);
                Product curProduct = products.Find(product => product.Name == productToBuy);

                if (curPerson.Money < curProduct.Price)
                {
                    Console.WriteLine($"{curPerson.Name} can't afford {curProduct.Name}");
                }
                else
                {
                    curPerson.Money -= curProduct.Price;
                    curPerson.ProductsBag.Add(curProduct);
                    Console.WriteLine($"{curPerson.Name} bought {curProduct.Name}");
                }
            }

            foreach (var person in persons)
            {
                Console.Write($"{person.Name} - ");

                if (person.ProductsBag.Count > 0)
                {
                    Console.WriteLine(String.Join(", ", person.ProductsBag));
                }
                else
                {
                    Console.Write("Nothing bought");
                    Console.WriteLine();
                }
            }

        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.ProductsBag = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ProductsBag { get; set; }
    }

    class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
