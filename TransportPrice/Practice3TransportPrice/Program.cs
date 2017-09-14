using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            int distanceToTravel = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            decimal result = 0;

            if (distanceToTravel >= 100)
            {
                result = distanceToTravel * 0.06m;
            }
            else
            {
                if (distanceToTravel>=20)
                {
                    result = distanceToTravel * 0.09m;
                }
                else
                {
                    if (dayNight=="day")
                    {
                        result = distanceToTravel * 0.79m + 0.7m;
                    }
                    else
                    {
                        result = distanceToTravel * 0.90m + 0.7m;
                    }
                }
            }
            Console.WriteLine("{0:f2}", result);

        }
    }
}
