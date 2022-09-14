using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeInput = Console.ReadLine();
            string input = Console.ReadLine();

            if (typeInput == "int")
            {
                int result = int.Parse(input);
                Console.WriteLine(Calculate(result));
            }
             else if (typeInput == "real")
            {
                double result = double.Parse(input);
                Console.WriteLine($"{Calculate(result):f2}");
            }
            else
                Console.WriteLine($"${input}$");
        }

        private static int Calculate(int result)
        {            
            return result * 2;
        }

        private static double Calculate(double result)
        {             
            return result * 1.5; 
        }
    }
}
