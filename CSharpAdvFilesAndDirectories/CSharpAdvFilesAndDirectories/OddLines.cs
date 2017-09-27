using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpAdvFilesAndDirectories
{
    class OddLines
    {
        public static void Main()
        {
            Console.WriteLine("Enter the full File path (including its name and extension): ");
            string inputFile = Console.ReadLine();

            while (!File.Exists(inputFile))
            {
                Console.WriteLine("Wrong path! Try again");
                Console.WriteLine("Enter the full File path (including its name and extension): ");

                inputFile = Console.ReadLine();
            }
            var inputData = File.ReadAllLines(inputFile);

            var result = new Queue<string>();
            for (int i = 0; i < inputData.Length; i++)
            {
                if (i%2!=0)
                {
                    result.Enqueue(inputData[i]);
                }
            }
            
            var inputFileName = Path.GetFileNameWithoutExtension(inputFile);
            var directory = inputFile.Substring(0, inputFile.LastIndexOf('\\'));
            var outputFile = Path.Combine(directory, inputFileName + "'s Odd Lines.txt");

            File.WriteAllLines(outputFile, result);

            Console.WriteLine("{0}The resulted file is saved here: {1}", Environment.NewLine, outputFile);

        }
    }
}
