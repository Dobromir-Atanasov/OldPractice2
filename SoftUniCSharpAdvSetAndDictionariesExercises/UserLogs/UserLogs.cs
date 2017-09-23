using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var log = new SortedDictionary<string, Dictionary<string, int>>();
            string tokenInput = Console.ReadLine();
            while (tokenInput != "end")
            {
                Split(tokenInput, log);
                tokenInput = Console.ReadLine();
            }
            foreach (var user in log)
            {
                Console.WriteLine("{0}:", user.Key);
                StringBuilder result = new StringBuilder();
                foreach (var ip in user.Value)
                {
                    result.Append(ip.Key);
                    result.Append(" => ");
                    result.Append(ip.Value);
                    result.Append(", ");
                }
                result.Remove(result.Length - 2, 2);
                result.Append(".");
                Console.WriteLine(result);

                //Following solution doesn't work in judge, but should work IRL
                //foreach (var ip in user.Value)
                //{
                //    Console.Write("{0} => {1}, ", ip.Key, ip.Value);
                //}
                //Console.Write("\b\b \b"); 
                //Console.WriteLine(".");
            }
        }
        static void Split(string token, SortedDictionary<string, Dictionary<string, int>> log)
        {
            string[] splitBySpace = token.Split(' ').ToArray();
            string ip = splitBySpace[0].Remove(0, 3);
            string message = splitBySpace[1].Remove(0, 8);
            string userName = splitBySpace[2].Remove(0, 5);
            if (!log.ContainsKey(userName))
            {
                log.Add(userName, new Dictionary<string, int>());
                log[userName].Add(ip, 1);
            }
            else if (!log[userName].ContainsKey(ip))
            {
                log[userName].Add(ip, 1);
            }
            else
            {
                log[userName][ip]++;
            }
        }
    }
}