using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSnowbolls  =int.Parse(Console.ReadLine());
            BigInteger bestSnowballValue = 0;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballTime = 0;
            int bestSnowballQuality = int.MinValue;
            for (int currSnowboll = 1; currSnowboll <= numSnowbolls; currSnowboll++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(snowballValue, snowballQuality);
                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballQuality = snowballQuality;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
