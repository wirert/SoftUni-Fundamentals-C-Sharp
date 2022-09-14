using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day > 0 && day <= days.Length)
            {
                Console.WriteLine(days[day -1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
