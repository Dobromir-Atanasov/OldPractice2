using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLiliBirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    money = money + (10 * i / 2);
                    money = money-1;
                }
                else
                {
                    money = money + toyPrice;
                }
            }
            if (money>=washerPrice)
            {
                Console.WriteLine("Yes! {0:f2}", (money-washerPrice));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", (washerPrice - money));
            }
        }
    }
}
