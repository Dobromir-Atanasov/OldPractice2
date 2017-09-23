using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var userTiming = new Dictionary<string, int>();
            var userIPs = new Dictionary<string, SortedSet<string>>();
            int logCounter = int.Parse(Console.ReadLine());
            Input(logCounter, userTiming, userIPs);
            Output(userTiming, userIPs);
        }
        static void Output(Dictionary<string, int> userTiming, Dictionary<string, SortedSet<string>> userIPs)
        {
            foreach (var user in userTiming.OrderBy(x=>x.Key))
            {
                string userName = user.Key;
                Console.Write("{0}: {1} ", userName, user.Value);
                Console.Write("[{0}]", string.Join(", ", userIPs[userName]));
                Console.WriteLine();
            }
        }
        static void Input(int logCounter, Dictionary<string, int> userTiming, Dictionary<string, SortedSet<string>> userIPs)
        {
            for (int i = 0; i < logCounter; i++)
            {
                string[] tokenInput = Console.ReadLine().Split(' ');
                string userName = tokenInput[1];
                string userIp = tokenInput[0];
                int userLogTime = int.Parse(tokenInput[2]);
                if (!userTiming.ContainsKey(userName))
                {
                    userTiming.Add(userName, userLogTime);
                    userIPs.Add(userName, new SortedSet<string>() { userIp });
                }
                else
                {
                    userTiming[userName] += userLogTime;
                    userIPs[userName].Add(userIp);
                }
            }
        }
    }
}
