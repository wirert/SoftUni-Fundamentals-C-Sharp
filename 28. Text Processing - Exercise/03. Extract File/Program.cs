using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] path = Console.ReadLine().Split(separator: "\\");

            string[] fileName = path[path.Length - 1].Split('.');

            Console.WriteLine($"File name: {fileName[0]}");
            Console.WriteLine($"File extension: {fileName[1]}");
        }
    }
}
