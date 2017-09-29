using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFundamentalsExams
{
    // 100 / 100 with decimal instead of double. well done
    // 85/100 points I'm missing something but can handle it... Could be done with some strings instead ot numbers.
    class Ressurection
    {
        static void Main()
        {
            int numberOfPhoenixes = int.Parse(Console.ReadLine());
            decimal[] lenght = new decimal[numberOfPhoenixes];
            decimal[] width = new decimal[numberOfPhoenixes];
            decimal[] wingLenght = new decimal[numberOfPhoenixes];

            for (int i = 0; i < numberOfPhoenixes; i++)
            {
                lenght[i] = decimal.Parse(Console.ReadLine());
                width[i] = decimal.Parse(Console.ReadLine());
                wingLenght[i] = decimal.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numberOfPhoenixes; i++)
            {
                var precision = 0;
                decimal x = (decimal)width[i];

                while (x * (decimal)Math.Pow(10, precision) !=
                         Math.Round(x * (decimal)Math.Pow(10, precision)))
                    precision++;
                decimal result = (lenght[i] * lenght[i] * (width[i] + 2 * wingLenght[i]));
                result += 0.000000000000000000001m;
                result = decimal.Round((result - 0.000000000000000000001m), precision, MidpointRounding.AwayFromZero);
                Console.WriteLine(result);
            }
        }
    }
}
