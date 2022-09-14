using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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

                if (!IsStudentInList(student, students))
                {
                    students.Add(student);
                }
                else
                {
                    Student currStudent = students.Find(student =>
                        student.FirstName == token[0] && student.LastName == token[1]);
                    currStudent.Age = int.Parse(token[2]);
                    currStudent.HomeTown = token[3];
                }


                token = Console.ReadLine().Split(' ');
            }

            string town = Console.ReadLine();

            foreach (var student in students.Where(student => town == student.HomeTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        private static bool IsStudentInList(Student currStudent, List<Student> students)
        {
            return students.Any(student => currStudent.FirstName == student.FirstName && currStudent.LastName == student.LastName);
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
