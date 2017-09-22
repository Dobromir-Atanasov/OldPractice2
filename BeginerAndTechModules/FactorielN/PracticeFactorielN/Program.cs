using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFactorielN
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            BigInteger resultFactorielN = 1;
            for (int i = 1; i <= nInput; i++)
            {
                resultFactorielN = resultFactorielN * i;
                Console.WriteLine("{0}! = {1}", i, resultFactorielN);
                Console.ReadKey();
            }
        }
    }
}
