using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            int stepsN = int.Parse(Console.ReadLine());
            int dancersN = int.Parse(Console.ReadLine());
            int daysForLearning = int.Parse(Console.ReadLine());


            //Calculations

            double stepsPerDay = stepsN/daysForLearning;
            //Console.WriteLine(stepsPerDay);
            //percent
            double percent = Math.Ceiling(stepsPerDay / stepsN * 100);
            //Console.WriteLine(percent);
            double percentPerDancer = percent / dancersN;

            //Output data
            if (percent <= 13) 
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentPerDancer);
            }
            else
            {
            Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", percentPerDancer);
            }
        }
    }
}
