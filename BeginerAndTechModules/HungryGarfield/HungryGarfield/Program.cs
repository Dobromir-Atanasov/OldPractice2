using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input all the data
            decimal money = decimal.Parse(Console.ReadLine());
            float rate = float.Parse(Console.ReadLine());
            float pizzaPrice = float.Parse(Console.ReadLine())/rate;
            float lasagnaPrice = float.Parse(Console.ReadLine())/rate;
            float sandwichPrice = float.Parse(Console.ReadLine())/rate;
            int pizzaQuantity = int.Parse(Console.ReadLine());
            int lasagnaQuantity = int.Parse(Console.ReadLine());
            int sandwichQuantity = int.Parse(Console.ReadLine());
            
            //Calculate
            float theTotalSum = ((pizzaPrice * pizzaQuantity) + (lasagnaPrice  * lasagnaQuantity) + (sandwichPrice  * sandwichQuantity));
            //Checking the condition and giving the Output
            if (money >= (theTotalSum))
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", money - theTotalSum);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", theTotalSum - money);
            }

        }
    }
}
