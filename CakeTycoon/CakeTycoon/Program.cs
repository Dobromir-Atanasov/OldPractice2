using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            ulong cakeWanted = ulong.Parse(Console.ReadLine());
            // Console.WriteLine(cakeWanted);
            float cakeKg = float.Parse(Console.ReadLine());
            // Console.WriteLine(cakeKg);
            uint flourAv = uint.Parse(Console.ReadLine());
            // Console.WriteLine(flourAv);
            uint truffelsAv = uint.Parse(Console.ReadLine());
            // Console.WriteLine(truffelsAv);
            uint truffelsPr = uint.Parse(Console.ReadLine());
            // Console.WriteLine(truffelsPr);
            double profit = 1.25; //profit 25%



            //Calculations and output
            if ((flourAv - (cakeWanted * cakeKg)) < 0)
            {
                Console.WriteLine("Can make only {0:f0} cakes, need {1:f2} kg more flour", (flourAv / cakeKg), ((cakeWanted * cakeKg) - flourAv));
            }
            else {
                Console.WriteLine("All products available, price of a cake: {0:f2}", (truffelsAv*truffelsPr/cakeWanted*1.25d));
            }
        }
    }
}
