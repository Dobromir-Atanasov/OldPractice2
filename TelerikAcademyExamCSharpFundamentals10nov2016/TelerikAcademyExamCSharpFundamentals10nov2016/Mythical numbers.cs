using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAcademyExamCSharpFundamentals10nov2016
{
    class Program
    {
        static void Main()
        {
            string tokenInput = Console.ReadLine();
            decimal firstDig = decimal.Parse(tokenInput[0].ToString());
            decimal secondDig = decimal.Parse(tokenInput[1].ToString());
            decimal thirdDig = decimal.Parse(tokenInput[2].ToString());
            decimal result = 0;
            if (thirdDig==0)
            {
                result = firstDig * secondDig;
            }
            else if (thirdDig<=5)
            {
                result = (firstDig * secondDig) / thirdDig;
            }
            else
            {
                result = (firstDig + secondDig) * thirdDig;
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
