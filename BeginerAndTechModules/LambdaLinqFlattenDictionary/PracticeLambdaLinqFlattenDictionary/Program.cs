using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqFlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> dictionary
                = new Dictionary<string, Dictionary<string, string>>();

            string[] inputTokens =
                Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (inputTokens[0] != "end")
            {
                string masterKey = inputTokens[0];
                string innerKey = inputTokens[1];

                if (masterKey == "flatten")
                {
                    dictionary[innerKey] = dictionary[innerKey]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                else //prevent exeption from 2 strings "flatten XXX"
                {
                    string innerValue = inputTokens[2];
                    if (!dictionary.ContainsKey(masterKey))
                    {
                        dictionary[masterKey] = new Dictionary<string, string>();
                        dictionary[masterKey][innerKey] = innerValue;
                    }
                    else
                    {
                        dictionary[masterKey][innerKey] = innerValue;
                    }
                }

                inputTokens =
                    Console.ReadLine()
                    .Split(' ')
                    .ToArray();
            }

            foreach (var save in dictionary.OrderByDescending(x => x.Key.Length))
            {
                Console.WriteLine("{0}", save.Key);
                int counter = 1;
                foreach (var item in save.Value.Where(x => x.Value != "flattened").OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine("{0}. {1} - {2}", counter, item.Key, item.Value);
                    counter++;
                }
                foreach (var item in save.Value.Where(x => x.Value == "flattened"))
                {
                    Console.WriteLine("{0}. {1}", counter, item.Key);
                    counter++;
                }
            }
        }
    }
}
