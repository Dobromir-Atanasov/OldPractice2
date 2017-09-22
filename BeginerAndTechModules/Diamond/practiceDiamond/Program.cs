using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new String('.', n), new String('*', n * 3));

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
                    new String ('.', n-1-i),"*", new String('.', i), new String('.', n*3));
            }
            Console.WriteLine(new String('*', n*5));

            for (int i = 1; i <= n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', i), new String('.', 5*n-2*i-2));
            }
            Console.WriteLine("{0}{1}{0}", new String('.', 2*n+1), new String('*', n-2));
        }
    }
}
