using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine().Split(", ").ToList();

            string[] command = Console.ReadLine().Split(':');

            while (command[0] != "course start")
            {
                switch (command[0])
                {
                    case "Add":
                        AddLesson(course, command);
                        break;
                    case "Insert":
                        InsertLesson(course, command);
                        break;
                    case "Remove":
                        RemoveLesson(course, command);
                        break;
                    case "Swap":
                        SwapLessons(course, command);
                        break;
                    case "Exercise":
                        AddExercise(course, command);
                        break;
                }


                command = Console.ReadLine().Split(':');
            }

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{course[i]}");
            }
        }
        private static List<string> AddExercise(List<string> course, string[] command)
        {
            if (course.Contains(command[1]))
            {
                if (course.Contains($"{command[1]}-Exercise"))
                    return course;

                for (int i = 0; i < course.Count; i++)
                {
                    if (course[i] != command[1]) continue;
                    course.Insert(i + 1, $"{command[1]}-Exercise");
                    return course;
                }
            }

            course.Add(command[1]);
            course.Add($"{command[1]}-Exercise");
            return course;
        }
        private static List<string> SwapLessons(List<string> course, string[] command)
        {
            if (!course.Contains(command[1]) || !course.Contains(command[2]))
                return course;

            bool isExercise1Exist = false;
            bool isExercise2Exist = false;
            if (course.Contains($"{command[1]}-Exercise"))
                isExercise1Exist = true;
            if (course.Contains($"{command[2]}-Exercise"))
                isExercise2Exist = true;

            for (int i = 0; i < course.Count; i++)
            {
                if (course[i] == command[1])
                {
                    course[i] = command[2];
                    if (isExercise2Exist && !isExercise1Exist)
                    {
                        course.Remove($"{command[2]}-Exercise");
                        course.Insert(i + 1, $"{command[2]}-Exercise");
                    }
                }
                else if (course[i] == command[2])
                {
                    course[i] = command[1];
                    if (isExercise1Exist && !isExercise2Exist)
                    {
                        course.Remove($"{command[1]}-Exercise");
                        course.Insert(i + 1, $"{command[1]}-Exercise");
                    }
                }
                else if (isExercise1Exist && isExercise2Exist && course[i] == $"{command[1]}-Exercise")
                    course[i] = $"{command[2]}-Exercise";
                else if (isExercise1Exist && isExercise2Exist && course[i] == $"{command[2]}-Exercise")
                    course[i] = $"{command[1]}-Exercise";
            }
            return course;
        }
        private static List<string> RemoveLesson(List<string> course, string[] command)
        {
            if (!course.Contains(command[1]))
                return course;

            course.Remove(command[1]);
            if (course.Contains($"{command[1]}-Exercise"))
                course.Remove($"{command[1]}-Exercise");
            return course;
        }
        private static List<string> InsertLesson(List<string> course, string[] command)
        {
            if (course.Contains(command[1]))
                return course;
            int index = int.Parse(command[2]);
            course.Insert(index, command[1]);
            return course;
        }
        private static List<string> AddLesson(List<string> course, string[] command)
        {
            if (course.Contains(command[1]))
                return course;

            course.Add(command[1]);
            return course;
        }
    }
}
