using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data
            decimal skPrice = decimal.Parse(Console.ReadLine());
            decimal cacaPrice = decimal.Parse(Console.ReadLine());
            decimal palamudQuantity = decimal.Parse(Console.ReadLine());
            decimal safridQuantity = decimal.Parse(Console.ReadLine());
            decimal midiQuantity = decimal.Parse(Console.ReadLine());
            decimal totalSum = 0m;
            
            //Calc
            totalSum = palamudQuantity * skPrice * 1.6m;
            totalSum = totalSum +(safridQuantity*cacaPrice*1.8m);
            totalSum = totalSum + (midiQuantity*7.5m);

            //Output
            Console.WriteLine(totalSum);

        }
    }
}
