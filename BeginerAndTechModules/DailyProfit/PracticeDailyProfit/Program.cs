using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data and variables
            int workDaysMonth = int.Parse(Console.ReadLine());
            decimal dailyMoney = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());

            //Calculations
            decimal monthlyMoney = dailyMoney * workDaysMonth;
            decimal yearMoney = monthlyMoney * 14.5m * .75m;

            //Output
            Console.WriteLine("{0:f2}", yearMoney*exchangeRate/365m);
        }
    }
}
