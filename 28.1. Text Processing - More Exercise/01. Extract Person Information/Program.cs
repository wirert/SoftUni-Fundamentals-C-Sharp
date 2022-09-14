using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());


            for (int i = 0; i < inputs; i++)
            {
                string input = Console.ReadLine();

                int startNameIndex = input.IndexOf('@') + 1;
                int endNameIndex = input.IndexOf('|');

                string name = input.Substring(startNameIndex, endNameIndex - startNameIndex);

                int startAgeIndex = input.IndexOf('#') + 1;
                int endAgeIndex = input.IndexOf('*');

                string age = input.Substring(startAgeIndex, endAgeIndex - startAgeIndex);

                Console.WriteLine($"{name} is { age } years old.");
            }
        }
    }
}
