using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesGroupContinentsCountriesAndCities
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, HashSet<string>>> dict = new SortedDictionary<string,SortedDictionary<string,HashSet<string>>>();
            
            int inputsCount = int.Parse(Console.ReadLine());

            InputData(inputsCount, dict);

            OutputToConsole(dict);
        }

        static void InputData(int inputsCount, SortedDictionary<string, SortedDictionary<string, HashSet<string>>> dict)
        {
            for (int i = 0; i < inputsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new SortedDictionary<string, HashSet<string>>();
                    dict[continent][country] = new HashSet<string>();
                    dict[continent][country].Add(city);
                }
                else if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new HashSet<string>();
                    dict[continent][country].Add(city);
                }
                else
                {
                    dict[continent][country].Add(city);
                }
            }
        }
        static void OutputToConsole(SortedDictionary<string, SortedDictionary<string, HashSet<string>>> dict) 
        {
            foreach (var continent in dict)
            {
                Console.WriteLine("{0}:", continent.Key);
                foreach (var item in continent.Value)
                {
                    Console.WriteLine("  {0} -> {1}", item.Key, string.Join(", ", item.Value.OrderBy(a=>a)));
                }
            }

        }
    }
}
