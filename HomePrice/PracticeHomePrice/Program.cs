using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHomePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaSmalestRoom = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var priceSq = double.Parse(Console.ReadLine());

            var priceSmallestRoom = areaSmalestRoom * priceSq;
            var priceKitchen = areaKitchen * priceSq;
            var priceBath = areaSmalestRoom / 2 * priceSq;
            var priceSecondRoom = areaSmalestRoom * 1.1 * priceSq;
            var priceThirdRoom = areaSmalestRoom * 1.1 * 1.1 * priceSq;

            var totalPrice = (priceSmallestRoom + priceKitchen + priceBath+priceSecondRoom + priceThirdRoom)*1.05;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
