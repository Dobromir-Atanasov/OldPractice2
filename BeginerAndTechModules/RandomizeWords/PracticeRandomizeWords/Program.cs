using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = Console.ReadLine();
            string [] givenStringArray = givenString.Split(' ');

            //Randomize
            Random rnd = new Random();
            string temp;
            int x;
            for (int i = 0; i < givenStringArray.Length; i++)
            {
                x = rnd.Next(0, givenStringArray.Length - 1);
                temp = givenStringArray[i];
                givenStringArray[i] = givenStringArray[x];
                givenStringArray[x] = temp;
            }
            //Output
            for (int i = 0; i < givenStringArray.Length; i++)
            {
                Console.WriteLine(givenStringArray[i]);
            }
        }
    }
}
