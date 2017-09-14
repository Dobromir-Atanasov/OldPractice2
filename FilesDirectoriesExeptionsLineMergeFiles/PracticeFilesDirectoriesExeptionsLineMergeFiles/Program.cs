using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PracticeFilesDirectoriesExeptionsLineMergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllLines("output.txt", File.ReadAllLines("input1.txt").Concat(File.ReadAllLines("input2.txt")).OrderBy(x => x).ToArray());
        }
    }
}
