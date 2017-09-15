using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            decimal studioDiscount = 1m;
            decimal appartmentDiscount = 1m;

            if ((month == "May" || month == "October") && days > 7)
            {
                studioDiscount = 0.95m;
            }
            if ((month == "May" || month == "October") && days > 14)
            {
                studioDiscount = 0.70m;
            }
            if ((month == "June" || month == "September") && days > 14)
            {
                studioDiscount = 0.80m;
            }
            if (days > 14)
            {
                appartmentDiscount = 0.90m;
            }
            if ((month == "May" || month == "October"))
            {
                Console.WriteLine("Apartment: {0:f2} lv.", 65m*appartmentDiscount*days);
                Console.WriteLine("Studio: {0:f2} lv.", 50m*studioDiscount*days);
            }
            if ((month == "June" || month == "September"))
            {
                Console.WriteLine("Apartment: {0:f2} lv.", 68.70m * appartmentDiscount*days);
                Console.WriteLine("Studio: {0:f2} lv.", 75.20m * studioDiscount*days);
            }
            if ((month == "July" || month == "August"))
            {
                Console.WriteLine("Apartment: {0:f2} lv.", 77m * appartmentDiscount*days);
                Console.WriteLine("Studio: {0:f2} lv.", 76m * studioDiscount*days);
            }



            //

        }
    }
}
