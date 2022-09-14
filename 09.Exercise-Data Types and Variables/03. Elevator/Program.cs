using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeole = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = numPeole * 1.0 / capacity;
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
