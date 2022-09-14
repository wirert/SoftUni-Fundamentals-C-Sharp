using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());

            int countOpenBrackets = 0;
            for (int i = 1; i <= numInputs; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    countOpenBrackets++;
                }
                else if (input == ")")
                {
                    if (countOpenBrackets == 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    else
                        countOpenBrackets--;
                }
                if (countOpenBrackets == 2)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (countOpenBrackets == 0)
                Console.WriteLine("BALANCED");
            else
                Console.WriteLine("UNBALANCED");
        }
    }
}
