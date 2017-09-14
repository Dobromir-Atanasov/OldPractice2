using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndTextProcesingDeserializeString
{
    class Program
    {
        static Dictionary<string, List<int>> tokens = new Dictionary<string, List<int>>();
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            while (token!="end")
            {
                string[] splittedToken = token
                    .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string charType = splittedToken[0];
                tokens[charType] = new List<int>();
                tokens[charType] = splittedToken[1]
                    .Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x=>int.Parse(x))
                    .ToList();
                token = Console.ReadLine();
            }
            string[] wholeString = new string[TotalLenghtOfTheString()];
            foreach (var tokenChar in tokens)
            {
                foreach (var position in tokenChar.Value)
                {
                    wholeString[position] = tokenChar.Key;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < wholeString.Length; i++)
            {
                sb.Append(wholeString[i]);
            }
            Console.WriteLine(sb);
        }
        static int TotalLenghtOfTheString()
        {
            int result = 0;
            foreach (var tokenChar in tokens)
            {
                result += tokenChar.Value.Select(x=>x).Sum();
            }
            return result;
        }
    }
}
