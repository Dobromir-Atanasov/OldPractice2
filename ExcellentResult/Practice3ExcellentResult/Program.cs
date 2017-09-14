using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal temp = decimal.Parse(Console.ReadLine());
            if (temp >= 5.5m)
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}
