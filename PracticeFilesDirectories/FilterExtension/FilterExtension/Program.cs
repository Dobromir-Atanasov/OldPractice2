using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilterExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileType = Console.ReadLine();
            fileType = "*." + fileType;
            string[] files = Directory.GetFiles("../../../input", fileType);
            for (int i = 0; i < files.Length; i++)
            {
                string output = files[i].Remove(0,15);
                Console.WriteLine(output);
            }
        }
    }
}
