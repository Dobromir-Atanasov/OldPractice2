using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMaxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxNumbers = int.Parse(Console.ReadLine());
            int temp = 0;

                for (int j = begin; j <= end; j++)
                {
                    for (int k = begin; k <= end; k++)
                    {
                        Console.Write("<{0}-{1}>", j, k);
                        temp++;
                        if (temp>=maxNumbers)
                        {
                            k = end;
                            j = end;
                        }
                    }
                }
                
        }
    }
}
