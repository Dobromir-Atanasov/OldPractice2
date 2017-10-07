using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAcademyCSharpFundamentalsExma09nov2016
{
    class MagicalNumbers
    {
        static void Main(string[] args)
        {
            string tokenInput = Console.ReadLine();
            double first = double.Parse(tokenInput[0].ToString());
            double second = double.Parse(tokenInput[1].ToString());
            double third = double.Parse(tokenInput[2].ToString());
            double result = 0;
            if (third==0)
            {
                result = 0.00001f;
            }
            else
            {
                if (second % 2 == 0)
                {
                    result = (first + second) / third;
                }
                else
                {
                    result = (first * second) / third;
                }
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
