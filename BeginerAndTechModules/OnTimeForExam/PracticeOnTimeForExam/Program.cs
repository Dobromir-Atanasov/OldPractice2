using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            int diffirence = (examHour * 60 + examMin) - (arrivalHour * 60 + arrivalMin);
            if (diffirence<0)
            {
                Console.WriteLine("Late");
                if (diffirence<-60)
                {
                    Console.WriteLine("{0}:{1} hours after the start", ((diffirence / 60) * -1), diffirence % 60 * -1);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", diffirence*-1);
                }
            }
            else
            {
                if (diffirence<=30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", diffirence);
                }
                else
                {
                    if (diffirence<60)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0:f2} minutes before the start", diffirence);
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1} hours before the start", ((diffirence / 60)), diffirence % 60);
                    }
                }
            }
        }
    }
}
