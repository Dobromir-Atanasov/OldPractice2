using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSignOfIntegerNumber
{
    class Program
    {
        static void PrintSign(int n)
        {
            if (n<0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            if (n==0)
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
            if (n>0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
