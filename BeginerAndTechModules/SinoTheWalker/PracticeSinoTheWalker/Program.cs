using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTime = Console.ReadLine();
            string[] arrString = strTime.Split(new string[] { ":" }, StringSplitOptions.None);
            ulong startTimeInSeconds = ulong.Parse(arrString[2]) + ulong.Parse(arrString[1]) * 60 + ulong.Parse(arrString[0]) * 3600;
            //Console.WriteLine(startTimeInSeconds);
            ulong steps = ulong.Parse(Console.ReadLine());
            ulong stepTime = ulong.Parse(Console.ReadLine());

            ulong timeTraveled = steps * stepTime;
            ulong arrivalTime = startTimeInSeconds + timeTraveled;

            ulong arrivalHours = arrivalTime / 3600;
            ulong arrivalMinutes = (arrivalTime - (arrivalHours * 3600)) / 60;
            ulong arrivalSeconds = (arrivalTime - (arrivalHours * 3600) - (arrivalMinutes * 60));

            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", arrivalHours%24, arrivalMinutes, arrivalSeconds);

        }
    }
}
