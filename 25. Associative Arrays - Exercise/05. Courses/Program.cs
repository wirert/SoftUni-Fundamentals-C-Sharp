using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" : ");

            var courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                string course = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(studentName);

                command = Console.ReadLine().Split(" : ");
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
