using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int peopleAvilable = int.Parse(Console.ReadLine());



            //calculations
            decimal hoursAvailable = (daysAvailable * 8m * .9m) + (peopleAvilable * daysAvailable * 2m);

            //output
            if (hoursAvailable >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(hoursAvailable - hoursNeeded));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(hoursAvailable - hoursNeeded)*-1m);
            }
        }
    }
}
