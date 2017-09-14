using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesMixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ':'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0]!="Over")
            {
                long value;
                if (long.TryParse(input[0], out value))
                {
                    dict[input[1]] = value;
                }
                else
                {
                    dict[input[0]] = long.Parse(input[1]);
                }
                input = Console.ReadLine()
                                .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            }
            foreach (KeyValuePair<string, long> item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
