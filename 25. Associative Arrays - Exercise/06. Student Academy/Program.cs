using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGrades = int.Parse(Console.ReadLine());

            var registerOfGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numGrades; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!registerOfGrades.ContainsKey(student))
                {
                    registerOfGrades.Add(student, new List<double>());
                }
                registerOfGrades[student].Add(grade);
            }

            foreach (var student in registerOfGrades
                         .Where(student => student.Value.Sum() / student.Value.Count >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Sum() / student.Value.Count:f2}");
            }
        }
    }
}
