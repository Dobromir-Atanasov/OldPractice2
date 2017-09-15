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
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = PowerAtoB(number, power);

            Console.WriteLine(result);
        }

        public static double PowerAtoB(double a, int b)
        {
            double result = 1;
            while (b > 0)
            {
                result *= a;
                b--;
            }
            return result;
        }
    }
}
