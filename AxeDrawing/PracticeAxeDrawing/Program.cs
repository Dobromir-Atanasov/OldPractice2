using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAxeDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}{3}", new String('-', 3 * n), new String('-', i), new String('-', n - i - 1), new String('-', n-1));
            }
            for (int i = 0; i < (n/2); i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new String('*', 3 * n), new String('-', n - 1), new String('-', n-1));
            }
            for (int i = 0; i < ((n/2)-1); i++)
            {
                Console.WriteLine("{0}{1}*{2}{3}{4}*{5}",
                    new String('-', 2*n),new String('-', n - i),new String('-', i),new String('-', n-1),new String('-', i),new String('-', n - i-1));
            }
            Console.WriteLine("{0}{1}*{2}{3}{4}*{5}",
     new String('-', 2 * n), new String('-', n - (n/2-1)), new String('*', n/2-1), new String('*', n - 1), new String('*', n/2-1), new String('-', n - (n/2)));


        }
    }
}
