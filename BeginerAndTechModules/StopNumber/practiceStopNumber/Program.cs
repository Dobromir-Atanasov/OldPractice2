using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceStopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i == s) {
                    i = m+1;
                    return;
                }
                    else {
                    if (i%2==0&&i%3==0)
                        Console.Write("{0} ", i);
                    }

                
            }
        }
    }
}
