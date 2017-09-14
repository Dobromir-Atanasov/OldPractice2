using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqDefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> initialData = new Dictionary<string, string>();

            string[] inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (inputTokens[0]!="end")
            {
                string tokenKey = inputTokens[0];
                string tokenValue = inputTokens[1];

                initialData[tokenKey] = tokenValue;

                inputTokens = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> nonEmptyStrings = new Dictionary<string, string>();
            nonEmptyStrings = initialData
                .OrderByDescending(a => a.Value.Length)
                .Where(a => a.Value != "null")
                .ToDictionary(k => k.Key, v => v.Value);

            Dictionary<string, string> emptyStrings = new Dictionary<string, string>();
            emptyStrings = initialData
                .Where(a => a.Value=="null")
                .ToDictionary(k => k.Key, v => defaultValue);


            foreach (var nonEmptyString in nonEmptyStrings)
            {
                Console.WriteLine("{0} <-> {1}", nonEmptyString.Key, nonEmptyString.Value);
            }

            foreach (var emptyString in emptyStrings)
            {
                Console.WriteLine("{0} <-> {1}", emptyString.Key, emptyString.Value);
            }

        }
    }
}
