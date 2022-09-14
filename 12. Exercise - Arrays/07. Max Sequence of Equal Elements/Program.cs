using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int equalDigits = 0;
            int startIndex = -1;
            int maxSequence = 0;
            int endIndex = -1;
            int bestStartIndex = int.MaxValue;
            int digitBestSeq = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int digit = arr[i];
                if (i == 0)
                {
                    if (arr[0] == arr[1])
                    {
                        startIndex = 0;
                        equalDigits++;
                    }

                }
                else if (i == arr.Length - 1)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        equalDigits++;
                        endIndex = i;
                        if (maxSequence == equalDigits && bestStartIndex < startIndex)
                        {
                            continue;
                        }
                        else if (maxSequence < equalDigits)
                        {
                            maxSequence = equalDigits;
                            bestStartIndex = startIndex;
                            digitBestSeq = digit;
                        }
                    }
                }
                else
                {
                    if (arr[i] == arr[i + 1])
                    {
                        equalDigits++;
                        if (arr[i] != arr[i - 1])
                        {
                            startIndex = i;
                        }
                    }
                    else
                    {
                        if (arr[i] == arr[i - 1])
                        {
                            equalDigits++;
                            endIndex = i;
                            if (maxSequence == equalDigits && bestStartIndex < startIndex)
                            {
                                equalDigits = 0;
                                continue;
                            }
                            else if (maxSequence < equalDigits)
                            {
                                maxSequence = equalDigits;
                                bestStartIndex = startIndex;
                                digitBestSeq = digit;
                            }
                        }
                        equalDigits = 0;
                    }
                }
            }
            int[] result = new int[maxSequence];
            for (int i = 0; i < maxSequence; i++)
            {
                result[i] = digitBestSeq;
            }
            Console.WriteLine($"{string.Join(' ', result)}");
        }
    }
}
