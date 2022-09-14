using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<Person> peoples = new List<Person>();

            while (input[0] != "End")
            {
                if (peoples.Any(person => person.Id == input[1]))
                {
                    var curPerson = peoples.Find(person => person.Id == input[1]);
                    curPerson.Name = input[0];
                    curPerson.Age = int.Parse(input[2]);
                }
                else
                {
                    Person person = new Person(input[0], input[1], int.Parse(input[2]));
                    peoples.Add(person);
                }

                input = Console.ReadLine().Split(' ');
            }

            peoples = peoples.OrderBy(person => person.Age).ToList();

            foreach (var person in peoples)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
