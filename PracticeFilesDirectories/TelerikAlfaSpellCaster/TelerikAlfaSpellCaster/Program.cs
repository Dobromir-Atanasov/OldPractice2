using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAlfaSpellCaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSentence = Console.ReadLine();
            string[] sentenceSplittedToWords = inputSentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string newSentence = string.Empty;
            bool allStringsAreEmpty = false;
            while (!allStringsAreEmpty)
            {
                for (int i = 0; i < sentenceSplittedToWords.Length; i++)
                {
                    allStringsAreEmpty = true;
                    if (sentenceSplittedToWords[i] != string.Empty)
                    {
                        string lastSimbol = sentenceSplittedToWords[i].Last().ToString();
                        newSentence = newSentence + lastSimbol;
                        sentenceSplittedToWords[i] = sentenceSplittedToWords[i].Substring(0, sentenceSplittedToWords[i].Length - 1);
                        allStringsAreEmpty = false;
                    }
                }
            }
            int lenghtOfTheString = newSentence.Length;
            for (int i = 0; i < newSentence.Length; i++)
            {
                var elementToMove = newSentence.ElementAt(i);
                int newPosition = (ElementNewPosition(elementToMove)+i)%lenghtOfTheString;
                if (newPosition==i)
                {
                    //do nothing
                }
                if (newPosition<i)
                {
                    newSentence = newSentence.Insert(newPosition, elementToMove.ToString());
                    string temp = newSentence.Remove(i + 1);
                    string temp2 = newSentence.Remove(0, i+2);
                    newSentence = temp + temp2;
                }
                if (newPosition>i)
                {
                    newSentence = newSentence.Insert(newPosition+1, elementToMove.ToString());
                    string temp = newSentence.Remove(i);
                    string temp2 = newSentence.Remove(0, i+1);
                    newSentence = temp + temp2;
                }
            }
            Console.WriteLine(newSentence);
        }

        static int ElementNewPosition(char elementToMove)
        {
            if (elementToMove - 96 < 0)
            {
                return elementToMove + 32 - 96;
            }
            else
            {
                return elementToMove - 96;
            }
        }
    }
}
