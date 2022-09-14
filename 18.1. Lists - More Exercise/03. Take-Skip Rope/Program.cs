using System;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> digits = new List<int>();
            List<char> chars = new List<char>();
            foreach (char @var in input)
            {
                if (Char.IsDigit(@var))
                    digits.Add((int)(@var - '0'));
                else
                    chars.Add(@var);
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                    takeList.Add(digits[i]);
                else
                    skipList.Add(digits[i]);
            }

            int index = -1;
            string result = null;
            for (int i = 0; i < skipList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    index++;
                    if (index == chars.Count)
                    {
                        Console.WriteLine(result);
                        return;
                    }
                    result += chars[index];
                }

                for (int j = 0; j < skipList[i]; j++)
                {
                    index++;
                    if (index == chars.Count)
                    {
                        Console.WriteLine(result);
                        return;
                    }
                }

            }

            Console.WriteLine(result);
        }
    }
}
