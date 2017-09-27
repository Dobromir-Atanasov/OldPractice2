using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the input data
            Console.WriteLine("Please enter words to check:");
            string[] wordsToCheck = Console.ReadLine().ToLower().Split();

            Console.WriteLine("Please, enter full_path\\filename.ext");
            string inputFile = Console.ReadLine();
            while (!File.Exists(inputFile))
            {
                Console.WriteLine("Incorect input!");
                Console.WriteLine("Please, enter full_path\\filename.ext");
                inputFile = Console.ReadLine();
            }
            //Read data from file, split it to words and check for matching
            var inputLines = File.ReadAllLines(inputFile);
            int[] wordsToCheckCounter = new int[wordsToCheck.Length];

            char[] separators = "\t\r\n\"'`/\\?!@#$%^&*+-_<>[]{}().,;: ".ToCharArray(); //I hope this will cover all posible extra symbols
            for (int i = 0; i < inputLines.Length; i++)
            {
                string text = inputLines[i];

                foreach (string word in text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries))
                {
                    for (int j = 0; j < wordsToCheck.Length; j++)
                    {
                        if (word == wordsToCheck[j])
                        {
                            wordsToCheckCounter[j]++;
                        }
                    }
                }
            }
            //I know it can be done by Dictionary, but this still works
            string[] result = new string[wordsToCheck.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = wordsToCheck[i] + " - " + wordsToCheckCounter[i];
            }
            //Output data to new file
            string fileName = Path.GetFileNameWithoutExtension(inputFile);
            string directory = inputFile.Substring(0, inputFile.LastIndexOf("\\"));
            var outputFile = Path.Combine(directory, fileName + "'s output.txt");

            File.WriteAllLines(outputFile, result);

            Console.WriteLine("{0}The resulted file is saved here: {1}", Environment.NewLine, outputFile);

        }
    }
}
