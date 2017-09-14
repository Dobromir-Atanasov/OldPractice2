using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDrawAFilledSquare
{    
    class Program
    {
        public static int n; 

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            PrintTopBottom();
            for (int i = 0; i < n-3; i++)
            {
                PrintMiddle(n);
            }
            PrintTopBottom();
        }

        static void PrintTopBottom()
        {
            Console.WriteLine(new string('-', 2*n));
        }

        static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

    }
}
