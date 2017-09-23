using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            var totalPopulationCounter = new Dictionary<string, long>();
            string tokenInput = Console.ReadLine();
            while (tokenInput != "report")
            {
                InputData(tokenInput, database, totalPopulationCounter);
                tokenInput = Console.ReadLine();
            }
            Print(database, totalPopulationCounter);
        }
        static void Print(Dictionary<string, Dictionary<string, int>> database, Dictionary<string, long> totalPopulationCounter)
        {
            foreach (var country in totalPopulationCounter.OrderByDescending(x=>x.Value))
            {
                string countryuName = country.Key;
                Console.WriteLine("{0} (total population: {1})", countryuName, totalPopulationCounter[countryuName]);
                foreach (var city in database[countryuName].OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
        static void InputData(string input, Dictionary<string, Dictionary<string, int>> database, Dictionary<string, long> totalPopulationCounter)
        {
            string[] tokenSplit = input.Split('|').ToArray();
            string city = tokenSplit[0];
            string country = tokenSplit[1];
            int population = int.Parse(tokenSplit[2]);
            if (!database.ContainsKey(country))
            {
                database.Add(country, new Dictionary<string, int>());
                database[country].Add(city, population);
            }
            else if (!database[country].ContainsKey(city))
            {
                database[country].Add(city, population);
            }
            else
            {
                database[country][city] += population;
            }
            if (!totalPopulationCounter.ContainsKey(country))
            {
                totalPopulationCounter.Add(country, population);
            }
            else
            {
                totalPopulationCounter[country] += population;
            }
        }
    }
}
