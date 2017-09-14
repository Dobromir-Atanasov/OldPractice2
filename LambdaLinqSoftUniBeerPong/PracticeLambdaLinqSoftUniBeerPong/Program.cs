using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqSoftUniBeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> participants
                = new Dictionary<string, Dictionary<string, long>>();
            //input
            string[] inputTokens = Console.ReadLine()
                .Split('|')
                .ToArray();

            while (inputTokens[0] != "stop the game")
            {
                string teamName = inputTokens[1];
                string playerName = inputTokens[0];
                long playerScore = long.Parse(inputTokens[2]);

                if (!participants.ContainsKey(teamName))
                {
                    participants[teamName] = new Dictionary<string, long>();
                }
                if (participants[teamName].Keys.Count < 3)
                {
                    participants[teamName].Add(playerName, playerScore);
                }

                inputTokens = Console.ReadLine()
                    .Split('|')
                    .ToArray();
            }
            //disqualification
            participants = participants
                .Where(kvp => kvp.Value.Keys.Count == 3)
                .ToDictionary(k => k.Key, v => v.Value)
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);


            int counter = 1;
            foreach (var team in participants)
            {
                Console.WriteLine("{0}. {1}; Players:", counter, team.Key);


                foreach (var players in team.Value
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value))
                {
                    Console.WriteLine("###{0}: {1}", players.Key, players.Value);
                }
                counter++;
            }
        }
    }
}
