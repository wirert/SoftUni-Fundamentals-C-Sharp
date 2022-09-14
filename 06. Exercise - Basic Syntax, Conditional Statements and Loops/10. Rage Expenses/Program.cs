using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            headsetPrice *= lostGames / 2;
            mousePrice *= lostGames / 3;
            keyboardPrice *= lostGames / 6;
            displayPrice *= lostGames / 12;
            double price = headsetPrice + mousePrice + keyboardPrice + displayPrice;
            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
