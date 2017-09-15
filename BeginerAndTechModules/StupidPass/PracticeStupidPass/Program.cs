using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStupidPass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data
            int num0 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int temp = 0;
            for (int i = 1; i <= num0; i++)
            {
                for (int j = 1; j <=num0 ; j++)
                {
                    for (int k = 1; k <= num1; k++)
                    {
                        for (int m = 1; m <= num1; m++)
                        {
                            for (int n = (Math.Max(i,j)+1); n <= num0; n++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, Convert.ToChar(k+96), Convert.ToChar(m + 96), n);
                            }
                        }
                    }
                }
            }
        }
    }
}
