using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int currOrder = 1; currOrder <= orderCount; currOrder++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal coffeePrice = capsulePrice * capsulesCount * days;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                totalPrice += coffeePrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
