using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectsSimpleClassesWebsites
{
    class Program
    {
        public class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Query { get; set; }
        }

        static List<Website> websites = new List<Website>();
        static void Main(string[] args)
        {
            GetInfoFromConsole();
            PrintData();
        }
        static void PrintData()
        {
            foreach (var website in websites)
            {
                if (website.Query!=null)
                {
                    Console.WriteLine("https://www.{0}.{1}/query?={2}", website.Host, website.Domain, string.Join("&", website.Query.Select(x => "[" + x + "]").ToArray()));
                }
                else
                {
                    Console.WriteLine("https://www.{0}.{1}", website.Host, website.Domain);
                }
            }
        }
        static void GetInfoFromConsole()
        {
            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (tokensInput[0] != "end")
            {
                string host = tokensInput[0];
                string domain = tokensInput[1];
                if (tokensInput.Length > 2)
                {
                    websites.Add(new Website { Host = host, Domain = domain, Query = tokensInput[2].Split(',').ToList() });
                }
                else
                {
                    websites.Add(new Website { Host = host, Domain = domain });
                }

                tokensInput = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
