using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDividing
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int temp = 0;

            int nInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < nInput; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp%2==0)
                {
                    p1++;
                }
                if (temp%3==0)
                {
                    p2++;
                }
                if (temp%4==0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", (decimal)p1 / nInput * 100);
            Console.WriteLine("{0:f2}%", (decimal)p2 / nInput * 100);
            Console.WriteLine("{0:f2}%", (decimal)p3 / nInput * 100);
        }
    }
}
