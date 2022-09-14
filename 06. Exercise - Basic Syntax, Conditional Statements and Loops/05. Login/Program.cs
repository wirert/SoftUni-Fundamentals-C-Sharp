using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPass = null;
            for (int charP = username.Length - 1; charP >= 0; charP--)
            {
                correctPass += username[charP];
            }
            int count = 0;
            string password = Console.ReadLine();
            while (password != correctPass)
            {
                Console.WriteLine("Incorrect password. Try again.");
                count++;
                if (count >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                password = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
