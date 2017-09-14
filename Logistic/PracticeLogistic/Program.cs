using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLogistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargos = int.Parse(Console.ReadLine());
            int temp = 0;
            double totalPrice = 0;
            double byBuss = 0;
            double byTruck = 0;
            double byTrain = 0;
            double totalTons = 0;

            for (int i = 0; i < cargos; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp <= 3)
                {
                    totalPrice = totalPrice + temp * 200;
                    byBuss = byBuss + temp;
                }
                else
                {
                    if (temp <= 11)
                    {
                        totalPrice = totalPrice + temp * 175;
                        byTruck = byTruck + temp;
                    }
                    else
                    {
                        totalPrice = totalPrice + temp * 120;
                        byTrain = byTrain + temp;
                    }
                }
            }
            totalTons = byBuss + byTruck + byTrain;
            Console.WriteLine("{0:f2}", (totalPrice / totalTons));
            Console.WriteLine("{0:f2}%", (byBuss / totalTons * 100));
            Console.WriteLine("{0:f2}%", (byTruck / totalTons * 100));
            Console.WriteLine("{0:f2}%", (byTrain / totalTons * 100));


        }
    }
}
