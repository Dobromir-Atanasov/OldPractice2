using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int temp = 0;
            
            //input data
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp<200)
                {
                    p1++;
                }
                if (temp>=200&&temp<=399)
                {
                    p2++;
                }
                if (temp>=400&&temp<=599)
                {
                    p3++;
                }
                if (temp>=600&&temp<=799)
                {
                    p4++;
                }
                if (temp>=800)
	            {
		             p5++;
	            }
            }
            Console.WriteLine("{0:f2}%", (decimal)p1 / numbers * 100);
            Console.WriteLine("{0:f2}%", (decimal)p2 / numbers * 100);
            Console.WriteLine("{0:f2}%", (decimal)p3 / numbers * 100);
            Console.WriteLine("{0:f2}%", (decimal)p4 / numbers * 100);
            Console.WriteLine("{0:f2}%", (decimal)p5 / numbers * 100);

        }
    }
}
