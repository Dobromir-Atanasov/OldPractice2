using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            char[] tokenInput = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> elements = new SortedDictionary<char, int>();
            foreach (var token in tokenInput)
            {
                if (!elements.ContainsKey(token))
                {
                    elements.Add(token, 1);
                }
                else
                {
                    elements[token] += 1;
                }
            }
            foreach (var element in elements)
            {
                Console.WriteLine("{0}: {1} time/s", element.Key, element.Value);
            }
        }
    }
}
