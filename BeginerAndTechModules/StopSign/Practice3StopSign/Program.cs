using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // string result = new String('-', 5); // -----
            Console.WriteLine("{0}.{1}_{1}.{0}", new string ('.', n), new string ('_', n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}_{1}\\\\{0}", new string('.', n-i), new string('_', n-1+i));
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', ((4*n+3)/2-4)));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', (n*4-1)-2*i));
            }
        }
    }
}
