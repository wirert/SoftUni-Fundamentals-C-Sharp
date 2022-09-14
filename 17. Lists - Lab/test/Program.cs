using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);
            binary = num.ToString("X");
            Console.WriteLine(binary);
            List<int> binNum = new List<int>();
            while (num != 0)
            {
               binNum.Add(num % 2);
               num /= 2;
            }
            binNum.Reverse();
            Console.WriteLine(string.Join("", binNum));

            
            long binaryNumber = 10011010010;
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = (int)(binaryNumber % 10);
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 *= 2;
            }
            Console.WriteLine($"Decimal Value : {decimalValue} ");

            string input = "ABC";
            int output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);
        }
    }
}
