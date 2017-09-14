using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int tempN = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int n = 1; n <= 9; n++)
                        {
                            if ((numberN % i == 0)&&(numberN%j==0)&&(numberN%k==0)&&(numberN%n==0))
                            {
                                tempN = i * 1000 + j * 100 + k * 10 + n;
                                Console.Write("{0} ", tempN);
                                tempN = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
