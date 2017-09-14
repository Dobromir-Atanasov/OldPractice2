using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeFilesDirectoriesExeptionsOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokensInput = File.ReadAllLines("input.txt");
            List<string> tokensOutput = new List<string>();
            for (int i = 1; i < tokensInput.Length; i+=2)
            {
                tokensOutput.Add(tokensInput[i]);
            }
            File.AppendAllLines("output.txt", tokensOutput);
        }
    }
}
