using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(getFibonaccci(number));
        }
        static int getFibonaccci(int n)
        {
            if (n==1)
            {
                return 1;
            }
            if (n==0)
            {
                return 1;
            }
            return getFibonaccci(n - 1) + getFibonaccci(n - 2);
        }
    }
}
