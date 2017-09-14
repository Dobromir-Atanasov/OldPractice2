using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data
            double excursionPrice = double.Parse(Console.ReadLine());
            double puzzleN = double.Parse(Console.ReadLine());
            double speakingN = double.Parse(Console.ReadLine());
            double bearN = double.Parse(Console.ReadLine());
            double minionsN = double.Parse(Console.ReadLine());
            double trucksN = double.Parse(Console.ReadLine());

            // Calculations
            double orderSum = puzzleN * 2.6 + speakingN * 3 + bearN * 4.1 + minionsN * 8.2 + trucksN * 2;
            if ((puzzleN +speakingN+bearN+minionsN+trucksN)>50)
            {
                orderSum *= 0.75;
            }

            // Result

        }
    }
}
