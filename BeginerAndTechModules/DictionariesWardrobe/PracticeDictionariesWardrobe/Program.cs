using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesWardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int inputsCount = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputsCount; cnt++)
            {
                string[] intro = Console.ReadLine().Split(' ');
                string color = intro[0];
                string sameColor = null;
                for (int i = 2; i < intro.Length; i++)
                {
                    sameColor += intro[i];
                }
                string[] clothesSameColour = sameColor.Split(',').ToArray();

                List<string> clothes = new List<string>();

                for (int i = 0; i < clothesSameColour.Length; i++)
                {
                    clothes.Add(clothesSameColour[i]);
                }

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                    foreach (string item in clothes)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
                else
                {
                    foreach (string item in clothes)
                    {
                        if (wardrobe[color].ContainsKey(item))
                        {
                            wardrobe[color][item]++;
                        }
                        else
                        {
                            wardrobe[color].Add(item, 1);
                        }
                    }
                }
            }

            string[] whatToWear = Console.ReadLine().Split(' ').ToArray();

            foreach (var color in wardrobe)
            {
                Console.WriteLine("{0} clothes:", color.Key);

                foreach (var clothe in color.Value)
                {
                    if (color.Key==whatToWear[0]&&clothe.Key==whatToWear[1])
                    {
                        Console.WriteLine("* {0} - {1} (found!)", clothe.Key, clothe.Value);
                    }
                    else
                    {
                        Console.WriteLine("* {0} - {1}", clothe.Key, clothe.Value);
                    }
                }
            }
        }
    }
}

