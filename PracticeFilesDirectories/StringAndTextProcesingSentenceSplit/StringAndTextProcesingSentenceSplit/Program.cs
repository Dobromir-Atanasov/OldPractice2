using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingSentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            string spliter = Console.ReadLine();
            inputData = inputData.Replace(spliter, "trytocatchme");
            string[] splitedInputData = inputData
                .Split(new string[] { "trytocatchme" }, StringSplitOptions.None)
                .ToArray();
            Console.WriteLine("[" + string.Join(", ", splitedInputData) + "]");
        }
    }
}
