using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());
            string bigestKegModel = null;
            double bigestVolume = double.MinValue;
            for (int currKeg = 1; currKeg <= numKegs; currKeg++)
            {
                string kegModel = Console.ReadLine();
                float kegRadius  = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * Math.Pow(kegRadius,2) * kegHeight;
                if (kegVolume > bigestVolume)
                {
                    bigestVolume = kegVolume;
                    bigestKegModel = kegModel;
                }
            }
            Console.WriteLine(bigestKegModel);
        }
    }
}
