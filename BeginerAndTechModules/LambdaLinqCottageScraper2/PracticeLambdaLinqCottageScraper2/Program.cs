using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqCottageScraper2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> storage = new List<KeyValuePair<string, int>>();

            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (tokensInput[0]!="chop chop")
            {
                string treeType = tokensInput[0];
                int treeLenght = int.Parse(tokensInput[1]);

                storage.Add(new KeyValuePair<string, int> (treeType, treeLenght));

                tokensInput = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string chopTreeType = Console.ReadLine();
            int chopLenght = int.Parse(Console.ReadLine());

            int logsCount = storage.Count;

            decimal pricePerMeter = Math.Round(((decimal)storage.Sum(x => x.Value) / logsCount), 2);
            decimal usedLogsPrice = (decimal)(storage.Where(x => x.Value >= chopLenght && x.Key==chopTreeType).Sum(x=>x.Value)) * pricePerMeter;
            decimal unusedLogsPrice = (((decimal)storage.Sum(x => x.Value) * pricePerMeter) - usedLogsPrice) /4; //25%

            Console.WriteLine("Price per meter: ${0:f2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}", usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:f2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", usedLogsPrice+unusedLogsPrice);
        }
    }
}
