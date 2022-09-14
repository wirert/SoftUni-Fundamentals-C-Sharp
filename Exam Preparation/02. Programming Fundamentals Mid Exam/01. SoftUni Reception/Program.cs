using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsPerHourEmpl1 = int.Parse(Console.ReadLine());
            int studentsPerHourEmpl2 = int.Parse(Console.ReadLine());
            int studentsPerHourEmpl3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = studentsPerHourEmpl1 + studentsPerHourEmpl2 + studentsPerHourEmpl3;
            int hours = 0;

            while (students > 0)
            {
                hours++;
                if (hours % 4 == 0)
                    continue;
                
                students -= studentsPerHour;
            }



            if (students < 0 && hours % 4 == 0)
            {
                hours++;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
