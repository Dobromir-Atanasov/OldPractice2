using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int adultsNumber = int.Parse(Console.ReadLine());
            decimal adultsPrice = 0m;
            int teensNumber = int.Parse(Console.ReadLine());
            decimal teensPrice = 0m;
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            decimal comision = 1.1m; //%
            decimal totalCost = 0m;

            //Calculations
            if (transport == "train")
            {
                teensPrice = 14.99m;
                adultsPrice = 24.99m;
            }

            if (transport == "train"&&(teensNumber+adultsNumber)>=50)
            {
                teensPrice = 14.99m*.5m;
                adultsPrice = 24.99m*.5m;
            }
            if (transport == "bus")
            {
                teensPrice = 28.50m;
                adultsPrice = 32.50m;
            }
            if (transport == "boat")
            {
                teensPrice = 39.99m;
                adultsPrice = 42.99m;
            }
            if (transport == "airplane")
            {
                teensPrice = 50.00m;
                adultsPrice = 70.00m;
            }
            totalCost = 1.1m*((adultsNumber*adultsPrice + teensNumber*teensPrice)*2 + ((nights)*82.99m));
            Console.WriteLine("{0:f2}", totalCost);
        }
    }
}
