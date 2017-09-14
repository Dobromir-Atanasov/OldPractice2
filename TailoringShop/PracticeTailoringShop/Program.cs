using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTailoringShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tokenQuantity = int.Parse(Console.ReadLine());
            double pokrivkiX = double.Parse(Console.ReadLine());
            double pokrivkiY = double.Parse(Console.ReadLine());

            double ploshtPokrivki = (double)tokenQuantity * (pokrivkiX + 2 * .3) * (pokrivkiY + 2 * .3);
            double ploshtKareta = (double)tokenQuantity * (Math.Max(pokrivkiX, pokrivkiY) / 2) * (Math.Max(pokrivkiX, pokrivkiY) / 2);

            double priceUSD = ploshtPokrivki * 7 + ploshtKareta * 9;
            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceUSD*1.85);
        }
    }
}
