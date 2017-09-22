using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCastleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}\\{1}{1}/{0}\\", new string('^', nInput/2), new string('_', nInput - (nInput/2)-2) );
            for (int i = 0; i < nInput-3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', nInput*2-2));
            }
            Console.WriteLine("|{0} {1}{1} {0}|", new string(' ', nInput / 2), new string('_', nInput - (nInput / 2) - 2));
            Console.WriteLine("\\{0}/{1}{1}\\{0}/", new string('_', nInput / 2), new string(' ', nInput - (nInput / 2) - 2));

        }
    }
}
