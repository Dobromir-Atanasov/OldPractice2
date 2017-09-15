using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesCountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (result.ContainsKey(input[i]))
                {
                    result[input[i]]++;
                }
                else
                {
                    result[input[i]] = 1;
                }
            }
            foreach (var key in result.Keys)
            {
                Console.WriteLine(key + " -> " + result[key]);
            }
        }
    }
}
