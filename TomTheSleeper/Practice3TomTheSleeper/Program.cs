using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3TomTheSleeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int restingDays = int.Parse(Console.ReadLine());
            int timeToPlay = 30000;

            int timePlayed = restingDays*127 + (365-restingDays)*63;

            if (timePlayed>=timeToPlay)
            {
                int hoursPlayed = (timePlayed-timeToPlay) / 60;
                int minutesPlayed = (timePlayed - timeToPlay) - hoursPlayed*60;
                Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play",
                    hoursPlayed, minutesPlayed);
            }
            else
            {
                int hoursPlayed = (timeToPlay - timePlayed) / 60;
                int minutesPlayed = (timeToPlay - timePlayed) - hoursPlayed*60;

                Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play",
                    hoursPlayed, minutesPlayed);

            }

        }
    }
}
