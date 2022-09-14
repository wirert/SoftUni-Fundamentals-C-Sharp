using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder multiplied = new StringBuilder();

            int reminder = 0;

            foreach (var charDigit in number.Reverse())
            {
                int digit = int.Parse(charDigit.ToString());
                int product = digit * multiplier + reminder;
                
                multiplied.Append(product % 10);
                reminder = (product) / 10;
            }

            if (reminder != 0)
                multiplied.Append(reminder);

            for (int i = multiplied.Length - 1; i >= 0; i--)
            {
                Console.Write(multiplied[i]);
            }
        }
    }
}
