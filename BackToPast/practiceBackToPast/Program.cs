using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceBackToPast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyInherited = Decimal.Parse(Console.ReadLine());
            decimal yearToLive = Decimal.Parse(Console.ReadLine());
            decimal moneySpend = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpend = moneySpend + 12000m;
                }

                else
                {
                    moneySpend = moneySpend + (12000m + (50 * (18 + (i - 1800))));
                }
            }
            if (moneySpend <= moneyInherited)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", moneyInherited - moneySpend);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", (-1m * (moneyInherited - moneySpend)));
            }

        }
    }
}
