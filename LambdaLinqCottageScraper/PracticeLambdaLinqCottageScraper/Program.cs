using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqCottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> storage = new Dictionary<string, List<double>>();

            string[] input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0]!="chop chop")
            {
                string treeType = input[0];
                int treeLenght = int.Parse(input[1]);

                if (!storage.ContainsKey(treeType))
                {
                    storage[treeType] = new List<double>();
                    storage[treeType].Add(treeLenght);
                }
                else
                {
                    storage[treeType].Add(treeLenght);
                }

                input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            string chopName = Console.ReadLine();
            double chopLenght = double.Parse(Console.ReadLine());

            double usedTreesLenght = 0;
            double unusedTreesLenght = 0;
            int numberOfTreePieces = 0;

            decimal pricePerMeter = 0;

            foreach (KeyValuePair<string, List<double>> tree in storage)
            {
                foreach (var item in tree.Value)
                {
                    if (tree.Key==chopName && item >=chopLenght)
                    {
                        usedTreesLenght += item;
                        numberOfTreePieces++;
                    }
                    else
                    {
                        unusedTreesLenght += item;
                        numberOfTreePieces++;
                    }
                }
            }

            pricePerMeter = Math.Round(((decimal)(usedTreesLenght + unusedTreesLenght) / (decimal)numberOfTreePieces), 2);

            Console.WriteLine("Price per meter: ${0:f2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}", pricePerMeter*(decimal)usedTreesLenght);
            Console.WriteLine("Unused logs price: ${0:f2}", pricePerMeter * (decimal)unusedTreesLenght / 4);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", ((decimal)usedTreesLenght * pricePerMeter + (decimal)unusedTreesLenght * pricePerMeter / 4));
        }
    }
}
