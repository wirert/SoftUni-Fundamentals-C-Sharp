using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            switch (typeGroup)
            {
                case "Students":
                    {
                        price = dayOfWeek == "Friday" ? 8.45 :
                            dayOfWeek == "Saturday" ? 9.8 :
                            10.46;
                        totalPrice = people * price;
                        if (people >= 30)
                        {
                            totalPrice *= 0.85;
                        }
                        break;
                    }
                case "Business":
                    {
                        price = dayOfWeek == "Friday" ? 10.90 :
                            dayOfWeek == "Saturday" ? 15.60 :
                            16;
                        totalPrice = people * price;
                        if (people >= 100)
                        {
                            totalPrice -= 10 * price;
                        }
                        break;
                    }
                case "Regular":
                    {
                        price = dayOfWeek == "Friday" ? 15 :
                            dayOfWeek == "Saturday" ? 20 :
                            22.5;
                        totalPrice = people * price;
                        if (people >= 10 && people <= 20)
                        {
                            totalPrice *= 0.95;
                        }
                        break;
                    }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}