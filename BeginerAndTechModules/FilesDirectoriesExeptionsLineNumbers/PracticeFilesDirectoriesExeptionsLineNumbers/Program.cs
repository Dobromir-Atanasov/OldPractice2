using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFilesDirectoriesExeptionsLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokensInput = File.ReadAllLines("input.txt");

            for (int i = 0; i < tokensInput.Length; i++)
            {
                tokensInput[i] = " • " + tokensInput[i];
            }
            File.AppendAllLines("output.txt", tokensInput);
        }
    }
}
