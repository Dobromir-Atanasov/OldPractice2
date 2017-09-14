using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            decimal bitcoins = decimal.Parse(Console.ReadLine());
            decimal cny = decimal.Parse(Console.ReadLine());
            decimal commision = decimal.Parse(Console.ReadLine());
            decimal bgn = 0m;
            decimal euro = 0m;
            
            //calculations
            bgn = bitcoins * 1168m;
            bgn = bgn + (cny * 0.15m * 1.76m);
            euro = bgn / 1.95m;


            //output
            Console.WriteLine("{0:f2}", euro*(1-(commision/100m)));

        }
    }
}
