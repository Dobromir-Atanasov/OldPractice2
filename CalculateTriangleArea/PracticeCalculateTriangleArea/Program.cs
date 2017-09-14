using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = TriangleArea(width, height);

            Console.WriteLine(area);
        }

        public static double TriangleArea (double a, double h)
        {
            return a * h / 2;
        }
    }
}
