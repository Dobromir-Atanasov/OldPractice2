using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictDict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            List<string> input = Console.ReadLine()
                .Split(new char[] {' ', '='}, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0]!="end")
            {
                int value;
                if (int.TryParse(input[1], out value))
                {
                        dict[input[0]] = value;
                }
                else
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        dict[input[0]] = dict[input[1]];
                    }
                }
                input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
            }
            foreach (string key in dict.Keys)
            {
                Console.WriteLine("{0} === {1}", key, dict[key]);
            }
        }
    }
}
