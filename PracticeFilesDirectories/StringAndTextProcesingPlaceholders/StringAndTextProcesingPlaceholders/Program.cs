using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingPlaceholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokens = Console.ReadLine();
            while (tokens!="end")
            {
                string[] splitedByDash = Spliter(tokens, " -> ");
                string outputString = splitedByDash[0];
                string[] elements = Spliter(splitedByDash[1], ", ");
                for (int i = 0; i < elements.Length; i++)
                {
                    string elementToReplace = "{" + i + "}";
                    outputString = outputString.Replace(elementToReplace, elements[i]);
                }
                Console.WriteLine(outputString);
                tokens = Console.ReadLine();
            }
        }
        static string[] Spliter(string token, string spliter)
        {
            string[] splited = token.Split(new string[] { spliter }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return splited;
        }
    }
}
