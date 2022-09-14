using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] curStudent = Console.ReadLine().Split();

                Students student = new Students(curStudent[0], curStudent[1], double.Parse(curStudent[2]));

                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";

    }
}
