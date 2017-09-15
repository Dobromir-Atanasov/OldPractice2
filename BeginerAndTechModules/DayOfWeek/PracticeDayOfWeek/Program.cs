using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Console.WriteLine(givenDate.DayOfWeek);
        }
    }
}
