using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePhotoPictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int picQuantity = int.Parse(Console.ReadLine());
            string picType = Console.ReadLine();
            string orderType = Console.ReadLine();
            double price = 0;

            switch (picType)
            {
                case "9X13":
                    if (picQuantity >= 50)
                    {
                        price = 0.16 * .95;
                    }
                    else
                    {
                        price = 0.16;
                    }
                    if (orderType=="online")
                    {
                        price = price * .98;
                    }
                    break;
                case "10X15":
                    if (picQuantity >= 80)
                    {
                        price = 0.16 * .97;
                    }
                    else
                    {
                        price = 0.16;
                    }
                    if (orderType=="online")
                    {
                        price = price * .98;
                    }
                    break;
                case "13X18":
                    if (picQuantity >= 50&&picQuantity<=100)
                    {
                        price = 0.38 * .97;
                    }
                    else if (picQuantity>100)
                    {
                        price = 0.38 * .95;
                    }
                    else
                    {
                        price = 0.38;
                    }

                    if (orderType=="online")
                    {
                        price = price * .98;
                    }
                    break;
                case "20X30":
                    if (picQuantity >= 10&&picQuantity<=50)
                    {
                        price = 2.9 * .93;
                    }
                    else if (picQuantity>50)
                    {
                        price = 2.9 * .91;
                    }
                    else
                    {
                        price = 2.9;
                    }

                    if (orderType=="online")
                    {
                        price = price * .98;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:f2}BGN", price*picQuantity);
        }
    }
}
