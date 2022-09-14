using System;
using System.Collections.Generic;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(1);
            if (n == 1)
            {
                Console.WriteLine(string.Join(' ', list));
                return;
            }
            list.Add(1);
            if (n == 2)
            {
                Console.WriteLine(string.Join(' ', list));
                return;
            }

            list.Add(2);
            if (n == 3)
            {
                Console.WriteLine(string.Join(' ', list));
                return;
            }

            int num = 0;
            
            for (int i = 3; i < n; i++)
            {
               num = list[i - 1] + list[i - 2] + list[i - 3];
                list.Add(num);
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
