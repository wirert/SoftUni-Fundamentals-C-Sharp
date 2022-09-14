using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senturies = int.Parse(Console.ReadLine());
            int years = 100 * senturies;
            int days = (int)(365.2422 * years);
            int hours = days * 24;
            uint minutes = (uint)(hours * 60);
            Console.WriteLine($"{senturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
