using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете път към файла, име и разширение:");
            string inputFile = Console.ReadLine();
            while (!File.Exists(inputFile))
            {
                Console.WriteLine("Грешни път, име или разширение.");
                Console.WriteLine("Моля въведете път към файла, име и разширение:");
                inputFile = Console.ReadLine();
            }
            var input = File.ReadAllLines(inputFile);
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = (i+1).ToString() + ". " + input[i];
                Console.WriteLine(input[i]);
            }
            string fileName = Path.GetFileNameWithoutExtension(inputFile);
            string directory = inputFile.Substring(0, inputFile.LastIndexOf("\\"));
            var outputFile = Path.Combine(directory, fileName + "'s output.txt");

            File.WriteAllLines(outputFile, input);

            Console.WriteLine("{0}The resulted file is saved here: {1}", Environment.NewLine, outputFile);
        }
    }
}
