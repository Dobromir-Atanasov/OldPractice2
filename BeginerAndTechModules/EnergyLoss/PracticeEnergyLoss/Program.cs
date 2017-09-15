using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEnergyLoss
{

    class Program
    {

        static void Main(string[] args)
        {
            //Input data
            int trainingDays = int.Parse(Console.ReadLine());
            int numberOfDancers = int.Parse(Console.ReadLine());
            var hoursPerDay = new List<int>();
            for (int i = 0; i < trainingDays; i++)
			{
                hoursPerDay.Add(int.Parse(Console.ReadLine()));
			}

            //Calculations
            int initialPower = 100 * numberOfDancers * trainingDays;
            int cumulativePower = 0;
            for (int i = 1; i <= trainingDays; i++)
			{
                if (IsOdd(i)) //days нечетни
                    {
                    if (IsOdd(hoursPerDay[i-1])) //hours
                        {
                            cumulativePower = cumulativePower + (numberOfDancers*30);
                        }
                    else
                        {
                            cumulativePower = cumulativePower + (numberOfDancers*49);
                        }
                    }
                else //days четни
                    {
                    if (IsOdd(hoursPerDay[i-1])) //hours
                        {
                            cumulativePower = cumulativePower + (numberOfDancers*65);
                        }
                    else
                        {
                            cumulativePower = cumulativePower + (numberOfDancers*68);
                        }
                    }
			 
			}
            double energyLeftPerDancer = ((double)initialPower - (double)cumulativePower) / (double)numberOfDancers / (double)trainingDays;

            //Output
            if (energyLeftPerDancer>=50) {
            Console.WriteLine("They feel good! Energy left: {0:f2}", energyLeftPerDancer);
            }
            else {
            Console.WriteLine("They are wasted! Energy left: {0:f2}", energyLeftPerDancer);
            }



        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
