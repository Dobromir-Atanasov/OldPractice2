using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(str1[0]);
            double x2 = double.Parse(str2[0]);
            double y1 = double.Parse(str1[1]);
            double y2 = double.Parse(str2[1]);
            Console.WriteLine("{0:f3}", DistanceBetweenPoints(x1, x2, y1, y2));
        }

        public static double DistanceBetweenPoints(double x1, double x2, double y1, double y2)
        {
            double x = Math.Abs(x2 - x1);
            double y = Math.Abs(y2 - y1);
            double c = Math.Sqrt(x * x + y * y);
            return c;
        }
    }
}
