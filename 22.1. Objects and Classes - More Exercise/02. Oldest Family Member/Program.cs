using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());

            Family family = new Family { Persons = new List<Person>() };

            for (int i = 0; i < numPeople; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    class Family
    {
        public List<Person> Persons { get; set; }


        public void AddMember(Person person) => Persons.Add(person);
        public Person GetOldestMember() => Persons.OrderByDescending(x => x.Age).First();
    }
}
