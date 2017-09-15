using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWinecraft
{
    class Program
    {
        public static int grownDays;
        public static List<int> grapes = new List<int>();
        static void Main(string[] args)
        {
            char[] splitSimbol = new char[] { ' ' };
            grapes = "10 11 12 13 19 13" //Console.ReadLine()
                .Split(splitSimbol, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            grownDays = int.Parse(Console.ReadLine());

            do
            {
                GrowningTime();
                KillSmallGrapes();
            } while (enoughtToBeGrown());

            PrintResult();

        }
        public static void PrintResult()
        {
            //print
        }
        public static void KillSmallGrapes()
        {
            //TODO kill
        }
        public static void GrowningTime()
        {
            for (int i = 0; i < grownDays; i++)
            {
                if (grapes[0]>grapes[1])
                {
                    grapes[0]++;
                }
                for (int j = 1; j < grapes.Count-1; j++)
                {
                    if (grapes[j]>grapes[j-1]&&grapes[j]>grapes[j+1])
                    {
                        grapes[j] += 3;
                        grapes[j - 1]--;
                        grapes[j + 1]--;
                    }
                }
            }
        }
        public static bool enoughtToBeGrown()
        {
            bool result = true;
            //TODO check it
            return result;
        }
    }
}
