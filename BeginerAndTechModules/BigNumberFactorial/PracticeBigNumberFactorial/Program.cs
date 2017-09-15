using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PracticeBigNumberFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGiven = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= numberGiven; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
