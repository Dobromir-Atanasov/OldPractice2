using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeFilesDirectoriesHTMLContents
{
    class Program
    {
        public static List<string> outputData = new List<string>();
        static void Main(string[] args)
        {
            string outputTag = null;
            string tokenInput = Console.ReadLine();

            while (tokenInput!="exit")
            {
                string[] tokens = tokenInput.Split(' ').ToArray();
                string tag = tokens[0];
                if (tag=="title")
                {
                    outputTag = "\t<title>" + tokens[1] + "</title>";
                }
                else
                {
                    string content = "\t"+"<"+tag+">"+tokens[1]+"</"+tag+">";
                    outputData.Add(content);
                }
                tokenInput = Console.ReadLine();
            }
            //add the rest
            outputData.Insert(0, "<body>");
            outputData.Insert(0, "</head>");
            outputData.Insert(0, outputTag);
            outputData.Insert(0, "<head>");
            outputData.Insert(0, "<html>");
            outputData.Insert(0, "<!DOCTYPE html>");
            outputData.Add("</body>");
            outputData.Add("</html>");
            File.AppendAllLines("../../../index.html", outputData);
        }
    }
}
