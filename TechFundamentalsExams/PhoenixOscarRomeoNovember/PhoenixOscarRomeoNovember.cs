using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixOscarRomeoNovember
{
    // CODE: PORN 100/100
    class PhoenixOscarRomeoNovember
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            string[] tokenInput = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (tokenInput[0] != "Blaze it!")
            {
                string creature = tokenInput[0];
                string mate = tokenInput[1];
                if (!dict.ContainsKey(tokenInput[0]))
                {
                    dict.Add(creature, new List<string>());
                    if (!dict[creature].Contains(mate))
                    {
                        dict[creature].Add(mate);
                    }
                }
                else
                {
                    if (!dict[creature].Contains(mate))
                    {
                        dict[creature].Add(mate);
                    }
                }

                tokenInput = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Print(dict);
        }
        static void Print(Dictionary<string, List<string>> dict)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var save in dict)
            {
                int counter = save.Value.Count;
                foreach (var squadMate in save.Value)
                {
                    if (dict.ContainsKey(squadMate))
                    {
                        if (dict[squadMate].Contains(save.Key))
                        {
                            counter--;
                        }
                    }
                }
                result.Add(save.Key, counter);
            }
            foreach (var save in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} : {1}", save.Key, save.Value);
            }
        }
    }
}
