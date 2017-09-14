using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeFilesDirectoriesExeptionsLineWordCount
{
    class Program
    {
        static Dictionary<string, int> wordsFound = new Dictionary<string, int>();
        static List<string> tokensWordsToCheck = new List<string>();
        static List<string> tokensInputToCheck = new List<string>();
        static void Main(string[] args)
        {
            string[] fileWords = File.ReadAllLines("words.txt");
            tokensWordsToCheck = fileWords[0].ToLower().Split(new string[] { " ", "-", ",", "?", "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] fileInput = File.ReadAllLines("input.txt");
            foreach (var fileLine in fileInput)
            {
                List<string> tempList = new List<string>();
                tempList = fileLine.ToLower().Split(new string[] { " ", "-", ",", "?", "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in tempList)
                {
                    tokensInputToCheck.Add(item);
                }
            }
            foreach (var wordInWords in tokensWordsToCheck)
            {
                foreach (var wordInInput in tokensInputToCheck)
                {
                    if (wordInInput == wordInWords)
                    {
                        if (!wordsFound.ContainsKey(wordInInput))
                        {
                            wordsFound.Add(wordInInput, 1);
                        }
                        else
                        {
                            wordsFound[wordInInput]++;
                        }
                    }
                }
            }
            List<string> outputTokens = new List<string>();
            foreach (var word in wordsFound.OrderByDescending(x => x.Value))
            {
                outputTokens.Add(word.Key + " - " + word.Value);
            }
            File.AppendAllLines("output.txt", outputTokens);
        }
    }
}
