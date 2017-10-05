using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAcademyExam9nov2016
{
    class GoingToAParty
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            bool stillRunning = true;
            int currentPosition = 0;
            int step = 0;
            while (stillRunning)
            {
                char letter = token[currentPosition];
                if (letter == '^')
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", currentPosition);
                    stillRunning = false;
                    break;
                }
                else if (letter>='a'&&letter<='z')
                {
                    step = letter - 96;
                }
                else
                {
                    step = (letter - 64) * (-1);
                }
                currentPosition += step;
                if (currentPosition>=token.Length||currentPosition<0)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", currentPosition);
                    stillRunning = false;
                }
            }
        }
    }
}
