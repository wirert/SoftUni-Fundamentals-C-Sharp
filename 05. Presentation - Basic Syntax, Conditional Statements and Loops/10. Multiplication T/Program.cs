using System;

namespace _10._Multiplication_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int operations = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num} X {operations} = {num * operations}");
                operations++;
            } while (operations <= 10);
        }
    }
}
