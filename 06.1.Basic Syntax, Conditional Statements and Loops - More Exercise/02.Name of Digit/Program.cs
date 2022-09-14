using System;

namespace _02.Name_of_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            string wordDigit = digit == 1 ? "one" : digit == 2 ? "two" : digit == 3 ? "three" : digit == 4 ? "four" : digit == 5 ? "five" : digit == 6 ? "six" : digit == 7 ? "seven" : digit == 8 ? "eight" : digit == 9 ? "nine" : "zero";
            Console.WriteLine(wordDigit);
                       
            //switch (digit)
            //{
            //    case 1:
            //        wordDigit = "one";
            //        break;
            //    case 2:
            //        wordDigit = "two";
            //        break;
            //    case 3:
            //        wordDigit = "three";
            //        break;
            //    case 4:
            //        wordDigit = "four";
            //        break;
            //    case 5:
            //        wordDigit = "five";
            //        break;
            //    case 6:
            //        wordDigit = "six";
            //        break;
            //    case 7:
            //        wordDigit = "seven";
            //        break;
            //    case 8:
            //        wordDigit = "eight";
            //        break;
            //    case 9:
            //        wordDigit = "nine";
            //        break;
            //    case 0:
            //        wordDigit = "zero";
            //        break;

            //}
            //Console.WriteLine(wordDigit);
        }
    }
}
