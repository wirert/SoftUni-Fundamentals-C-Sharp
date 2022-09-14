using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStrings = int.Parse(Console.ReadLine());

            int[] result = new int[numStrings];

            for (int i = 0; i < numStrings; i++)
            {
                string word = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < word.Length; j++)
                {

                    if ("aoueiAOUEI".Contains(word[j]))
                    {
                        sum += word[j] * word.Length;
                    }
                    else
                        sum += word[j] / word.Length;

                }
                result[i] = sum;
            }
            Array.Sort(result);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
