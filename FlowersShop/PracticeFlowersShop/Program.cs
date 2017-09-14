using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnQuan = int.Parse(Console.ReadLine());
            var ziumQuan = int.Parse(Console.ReadLine());
            var rozeQuan = int.Parse(Console.ReadLine());
            var cactusQuan = int.Parse(Console.ReadLine());
            var priceOfGift = double.Parse(Console.ReadLine());

            var totalProfit = (magnQuan * 3.25 + ziumQuan * 4 + rozeQuan * 3.5 + cactusQuan*8)*.95;

            if (totalProfit>=priceOfGift)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalProfit - priceOfGift));

            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceOfGift - totalProfit));

            }

        }
    }
}
