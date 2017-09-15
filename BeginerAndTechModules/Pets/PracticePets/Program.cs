using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            decimal foodKg = decimal.Parse(Console.ReadLine());
            decimal dogFood = decimal.Parse(Console.ReadLine());
            decimal catFood = decimal.Parse(Console.ReadLine());
            decimal turtleFood = decimal.Parse(Console.ReadLine());
            decimal totalFood = 0m;

            //Calcs
            totalFood = totalFood + (dogFood * days);
            totalFood = totalFood + (catFood * days);
            totalFood = totalFood + (turtleFood * days)/1000;
            if (foodKg>=totalFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKg - totalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling((foodKg - totalFood)*-1m));
            }
        }
    }
}
