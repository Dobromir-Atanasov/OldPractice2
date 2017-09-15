using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikSpellCaster
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
            char[] sentence = newSentence.ToCharArray();
            for (int i = 0; i < sentence.Length; i++)
            {
                char chToMove = sentence[i];
                int stepToMove = (int)chToMove - 96;
                if (stepToMove < 0)
                {
                    stepToMove += 32;
                }
                int newPosition = (sentence.Length + i + stepToMove) % sentence.Length;
                if (newPosition < i)
                {
                    for (int j = i; j > newPosition; j--)
                    {
                        sentence[j] = sentence[j - 1];
                    }
                }
                else
                {
                    for (int j = i; j < newPosition; j++)
                    {
                        sentence[j] = sentence[j + 1];
                    }
                }
                sentence[newPosition] = chToMove;
            }
            Console.WriteLine(string.Join("", sentence));
        }
    }
}
