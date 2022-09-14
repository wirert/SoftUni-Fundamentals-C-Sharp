using System;

namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string result = month == 1 ? "January" :
                month == 2 ? "February" :
                month == 3 ? "March" :
                month == 4 ? "April" :
                month == 5 ? "May" :
                month == 6 ? "June" :
                month == 7 ? "July" :
                month == 8 ? "August" :
                month == 9 ? "September" :
                month == 10 ? "Octomber" :
                month == 11 ? "November" :
                month == 12 ? "December" : "Error!";
            Console.WriteLine(result);
        }
    }
}
