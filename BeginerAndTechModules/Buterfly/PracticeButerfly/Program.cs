using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeButerfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nInput-2; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', nInput-2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', nInput-2));
                }
            }
            Console.WriteLine("{0}@{0}", new string(' ', nInput - 1));
            for (int i = 1; i <= nInput - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', nInput - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', nInput - 2));
                }
            }

        }
    }
}
