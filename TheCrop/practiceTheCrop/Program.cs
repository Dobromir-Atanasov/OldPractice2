using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceTheCrop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vineyardArea = Decimal.Parse(Console.ReadLine());
            decimal vinePerSquareArea = Decimal.Parse(Console.ReadLine());
            decimal litresNeeded = Decimal.Parse(Console.ReadLine());
            decimal workersAvailable = Decimal.Parse(Console.ReadLine());

            decimal vineMade = vineyardArea * vinePerSquareArea * 0.40m / 2.50m;
            if (vineMade < litresNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litresNeeded - vineMade));
            }
            else {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vineMade));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vineMade - litresNeeded), Math.Ceiling((vineMade - litresNeeded)/workersAvailable));
            }
        }
    }
}
