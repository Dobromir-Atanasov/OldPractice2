using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingFindTheLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenceToSearchIn = Console.ReadLine();
            string tokenInput = Console.ReadLine();
            string letterToSearchFor = tokenInput.ElementAt(0).ToString();
            string[] splittedToken = tokenInput.Split(' ').ToArray();
            int letterRepeats = int.Parse(splittedToken[1]);

            int startingIndex = 0;
            int elementFoundAtPosition = 0;

            for (int i = 0; i < letterRepeats; i++)
            {
                elementFoundAtPosition = sentenceToSearchIn.IndexOf(letterToSearchFor, startingIndex);
                if (elementFoundAtPosition==-1)
                {
                    Console.WriteLine("Find the letter yourself!");
                    break;
                }
                else if (i == letterRepeats-1)
                {
                    Console.WriteLine(elementFoundAtPosition);
                }
                startingIndex = elementFoundAtPosition+1;
            }
        }
    }
}
