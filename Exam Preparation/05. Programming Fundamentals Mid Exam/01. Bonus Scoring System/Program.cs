using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int attendencesWithMaxBonus = 0;

            for (int i = 1; i <= students; i++)
            {
                int currAttendences = int.Parse(Console.ReadLine());
                double bonus = currAttendences * 1.0 / lectures * (5 + additionalBonus);

                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    attendencesWithMaxBonus = currAttendences;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {attendencesWithMaxBonus} lectures.");
        }
    }
}
