using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesCitiesByConstinentsAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dictContinens = new Dictionary<string,Dictionary<string,List<string>>>();

            int countSaves = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSaves; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];


                if (!dictContinens.ContainsKey(continent))
                {
                    dictContinens.Add(continent, new Dictionary<string, List<string>>());
                    dictContinens[continent].Add(country, new List<string>());
                    dictContinens[continent][country].Add(city);
                }
                else if (!dictContinens[continent].ContainsKey(country))
                {
                    dictContinens[continent].Add(country, new List<string>());
                    dictContinens[continent][country].Add(city);
                }
                else
                {
                    dictContinens[continent][country].Add(city);
                }
            }

            foreach (var continent in dictContinens)
            {
                Console.WriteLine("{0}:", continent.Key);
                foreach (var item in continent.Value)
                {
                    Console.WriteLine("  {0} -> {1}", item.Key, string.Join(", ", item.Value));
                }
            }
        }
    }
}
