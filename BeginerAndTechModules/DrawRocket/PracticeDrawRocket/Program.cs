using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDrawRocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}/{2}{2}\\{1}{0}", new string('.', n/2), new string('.', n-1-i), new string(' ', i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}{2}{1}\\{0}", new string('.', n / 2 - i), new string('*', i), new string('*', n * 2-2));
            }
        }
    }
}
