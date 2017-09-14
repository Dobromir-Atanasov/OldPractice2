using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeScholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeBGN = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = minSalary * .35;
            double maxScholarship = Math.Floor(uspeh * 25);

            if (uspeh>=5.5)
            {
                //if (socialScholarship>maxScholarship)
                //{
                    //Console.WriteLine("You get a Social scholarship {0:f0} BGN", socialScholarship);
               // }
                //else
                //{
                    Console.WriteLine("You get a scholarship for excellent results {0:f0} BGN", maxScholarship);
                //}
            }
            else
            {
                if (incomeBGN < minSalary && uspeh > 4.5)
                {
                    Console.WriteLine("You get a Social scholarship {0:f0} BGN", socialScholarship);

                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
