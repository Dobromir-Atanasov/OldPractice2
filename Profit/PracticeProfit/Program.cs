using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int coinOne = 0; coinOne <= one; coinOne++)
            {
                for (int coinTwo = 0; coinTwo <= two; coinTwo++)
                {
                    for (int coinFive = 0; coinFive <= five; coinFive++)
                    {
                        if (coinOne+coinTwo*2+coinFive*5 ==sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", coinOne, coinTwo, coinFive, sum);
                        }
                    }
                }
            }

        }
    }
}
