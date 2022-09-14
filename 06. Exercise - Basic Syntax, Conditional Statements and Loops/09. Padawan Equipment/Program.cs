using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            sabersPrice *= Math.Ceiling(students * 1.1);
            robesPrice *= students;
            beltsPrice *= students - Math.Floor(students / 6.0);
            double totalPrice = sabersPrice + robesPrice + beltsPrice;
            if (totalPrice <= budget)
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            else
                Console.WriteLine($"John will need {totalPrice - budget:f2}lv more.");
        }
    }
}
