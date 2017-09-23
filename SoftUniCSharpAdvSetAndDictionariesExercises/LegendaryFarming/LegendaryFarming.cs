using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        public static Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        public static Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("shards", 0);
            bool materialFound = false;
            do
            {
                string inputToken = Console.ReadLine().ToLower();
                string[] input = inputToken.Split(' ');
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];
                    switch (material)
                    {
                        case "shards":
                            keyMaterials["shards"] += quantity;
                            if (keyMaterials["shards"]>=250)
                            {
                                materialFound = true;
                            }
                            break;
                        case "fragments":
                            keyMaterials["fragments"] += quantity;
                            if (keyMaterials["fragments"] >= 250)
                            {
                                materialFound = true;
                            }
                            break;
                        case "motes":
                            keyMaterials["motes"] += quantity;
                            if (keyMaterials["motes"] >= 250)
                            {
                                materialFound = true;
                            }
                            break;
                        default:
                            if (!junkMaterials.ContainsKey(material))
                            {
                                junkMaterials.Add(material, quantity);
                            }
                            else
                            {
                                junkMaterials[material] += quantity;
                            }
                            break;
                    }
                    if (materialFound==true)
                    {
                        break;
                    }
                }
            } while (keyMaterials["shards"] < 250 && keyMaterials["fragments"] < 250 && keyMaterials["motes"] < 250);
            string maxMaterialFound = string.Empty;
            foreach (var material in keyMaterials)
            {
                if (material.Value >= 250)
                {
                    switch (material.Key)
                    {
                        case "shards":
                            Console.WriteLine("Shadowmourne obtained!");
                            maxMaterialFound = "shards";
                            break;
                        case "fragments":
                            Console.WriteLine("Valanyr obtained!");
                            maxMaterialFound = "fragments";
                            break;
                        case "motes":
                            Console.WriteLine("Dragonwrath obtained!");
                            maxMaterialFound = "motes";
                            break;
                        default:
                            break;
                    }
                }
            }
            keyMaterials[maxMaterialFound] -= 250;
            foreach (var material in keyMaterials.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
            foreach (var material in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }
        }
    }
}
