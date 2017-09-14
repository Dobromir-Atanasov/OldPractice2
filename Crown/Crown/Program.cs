using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            int N = int.Parse(Console.ReadLine());
            //First line
            Console.Write("@");
            for (int i = 0; i < ( N - 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write("@");
            for (int i = 0; i < ( N - 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write("@\n");
            //Lines two to N-2




            //last two lines
            for (int i = 0; i < (2 * N - 1); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < (2 * N - 1); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
