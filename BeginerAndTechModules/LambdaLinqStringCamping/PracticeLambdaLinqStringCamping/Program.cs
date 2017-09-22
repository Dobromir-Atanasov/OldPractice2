using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqStringCamping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> owners = new Dictionary<string, Dictionary<string, int>>();

            string[] inputTokens = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (inputTokens[0]!="end")
            {
                string name = inputTokens[0];
                string camper = inputTokens[1];
                int days = int.Parse(inputTokens[2]);

                if (!owners.ContainsKey(name))
                {
                    owners[name] = new Dictionary<string, int>();
                    owners[name].Add(camper, days);
                }
                else if (!owners[name].ContainsKey(camper))
                {
                    owners[name].Add(camper, days);
                }
                else
                {
                    owners[name][camper] = days;
                }

                inputTokens = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> owner in owners
                                                                            .OrderByDescending(x => x.Value.Count)
                                                                            .ThenBy(x => x.Key.Length)
                                                                            .ToDictionary(x => x.Key, x => x.Value))
            {
                int nightsStayed = 0;
                Console.WriteLine("{0}: {1}", owner.Key, owner.Value.Values.Count);
                foreach (KeyValuePair<string, int> camper in owner.Value)
                {
                    Console.WriteLine("***{0}", camper.Key);
                    nightsStayed += camper.Value;
                }
                Console.WriteLine("Total stay: {0} nights", nightsStayed);
            }
        }
    }
}
