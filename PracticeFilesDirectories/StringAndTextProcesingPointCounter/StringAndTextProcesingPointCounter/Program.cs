using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcesingPointCounter
{
    class Program
    {
        static Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();

        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            while (token != "Result")
            {
                token = RemoveTrash(token);
                TokenToDictionary(token);
                token = Console.ReadLine();
            }
            foreach (var team in teams.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine("{0} => {1}", team.Key, team.Value.Values.Sum());

                foreach (var player in team.Value.OrderByDescending(x => x.Value).Take(1))
                {
                    Console.WriteLine("Most points scored by {0}", player.Key);
                }
            }
        }
        static void TokenToDictionary(string token)
        {
            string[] splitedToken = token.Split('|');
            string team = string.Empty;
            string player = string.Empty;
            int point = int.Parse(splitedToken[2]);
            if (splitedToken[0].Last() > 96) //checking order of TEAM | Player
            {
                team = splitedToken[1];
                player = splitedToken[0];
            }
            else
            {
                player = splitedToken[1];
                team = splitedToken[0];
            }
            if (!teams.Keys.Contains(team))
            {
                teams.Add(team, new Dictionary<string, int>());
            }
            teams[team][player] = point;
        }
        static string RemoveTrash(string token)
        {
            string result = token
                    .Replace("@", string.Empty)
                    .Replace("%", string.Empty)
                    .Replace("$", string.Empty)
                    .Replace("*", string.Empty);
            return result;
        }
    }
}
