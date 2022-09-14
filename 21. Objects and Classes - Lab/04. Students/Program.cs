using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] token = Console.ReadLine().Split(' ');

            List<Student> students = new List<Student>();

            while (token[0] != "end")
            {
                Student student = new Student(token[0], token[1], int.Parse(token[2]), token[3]);

                students.Add(student);

                token = Console.ReadLine().Split(' ');
            }

            string town = Console.ReadLine();

            foreach (var student in students.Where(student => town == student.HomeTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
