using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVeloRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var junBikers = int.Parse(Console.ReadLine());
            var senBikers = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();

            double totalSum = 0;

            if (trace=="trail")
            {
                totalSum = junBikers * 5.5 + senBikers * 7;
            }
            if (trace == "cross-country")
            {
                if (junBikers+senBikers>=50)
                {
                    totalSum = (junBikers * 8 + senBikers * 9.5)*.75;
                }
                else
                {
                    totalSum = (junBikers * 8 + senBikers * 9.5);
                }
            }
            if (trace == "downhill")
            {
                totalSum = junBikers * 12.25 + senBikers * 13.75;
            }
            if (trace == "road")
            {
                totalSum = junBikers * 20 + senBikers * 21.50;
            }
            totalSum = totalSum * .95;
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
