using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCountOfIntegers2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitTime = false;
            int result;
            bool isInt;
            int counter =0;
            do
            {
                isInt = Int32.TryParse(Console.ReadLine(), out result);
                if (isInt)
                {
                    counter++;
                }
                else
                {
                    exitTime = true;
                }
                
            } while (exitTime!=true);
            Console.WriteLine(counter);
        }
    }
}
