using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergingTwoFilesIntoThirdOne
{
    class MergingTwoFilesIntoThirdOne
    {
        static void Main()
        {
            Console.WriteLine("Please add the full path and name of the first file to be merged");
            string firstFile = Console.ReadLine();
            while (!File.Exists(firstFile))
            {
                Console.WriteLine("Incorect path, file name or extenshion");
                firstFile = Console.ReadLine();
            }
            string secondFile = Console.ReadLine();
            while (!File.Exists(secondFile))
            {
                Console.WriteLine("Incorect path, file name or extenshion");
                firstFile = Console.ReadLine();
            }

            List<string> result = new List<string>();
            foreach (var line in File.ReadAllLines(firstFile))
            {
                result.Add(line);
            }
            foreach (var line in File.ReadAllLines(secondFile))
            {
                result.Add(line);
            }
            // result.Sort(); //We can use LINQ
            string outputDir = firstFile.Substring(0, firstFile.LastIndexOf('\\'));
            string outputName = Path.GetFileNameWithoutExtension(firstFile);

            var OutputFullPathAndName = Path.Combine(outputDir, outputName.Substring(0, 3) + "Merged.txt");
            
            File.WriteAllLines(OutputFullPathAndName, result.OrderBy(x=>x));

            Console.WriteLine("You can find Output here: {0}", OutputFullPathAndName);
        }
    }
}
