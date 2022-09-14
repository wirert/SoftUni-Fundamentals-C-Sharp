using System;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x11 = double.Parse(Console.ReadLine());
            double y11 = double.Parse(Console.ReadLine());
            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());
            double x21 = double.Parse(Console.ReadLine());
            double y21 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            
            FindLongerLine(x11, y11, x12, y12, x21, y21, x22, y22);
            
        }

        private static void FindLongerLine(double x11, double y11, double x12, double y12, double x21, double y21, double x22, double y22)
        {
            double d1 = Math.Pow(x11 - x12, 2) + Math.Pow(y11 - y12, 2);
            double d2 = Math.Pow(x21 - x22, 2) + Math.Pow(y21 - y22, 2);
            if (d1 > d2)
            {
                FindClosestCoordinates(x11, y11, x12, y12);
            }
            else
            {
                FindClosestCoordinates(x21, y21, x22, y22);
            }
        }

        private static void FindClosestCoordinates(double x1, double y1, double x2, double y2)
        {
            double d1 = x1 * x1 + y1 * y1;
            double d2 = x2 * x2 + y2 * y2;
            Console.WriteLine(d1 <= d2 ? $"({x1}, {y1})({x2}, {y2})" : $"({x2}, {y2})({x1}, {y1})");
        }
    }
}
