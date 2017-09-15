using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqRegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> storedUsers = new Dictionary<string, DateTime>();

            string[] inputTokens = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.None)
                .ToArray();

            while (inputTokens[0]!="end")
            {
                string userName = inputTokens[0];
                DateTime userRegisteredAt = DateTime.ParseExact(inputTokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (!storedUsers.ContainsKey(inputTokens[0]))
                {
                    storedUsers.Add(userName, userRegisteredAt);
                }
                else
                {
                    storedUsers[userName] = userRegisteredAt;
                }

                inputTokens = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.None)
                    .ToArray();
            }

            Dictionary<string, DateTime> sortedUsers = new Dictionary<string, DateTime>();

            //sortedUsers = storedUsers.Reverse().ToDictionary(k => k.Key, v => v.Value);
            sortedUsers = storedUsers
                .Reverse()
                .OrderBy(a => a.Value)
                .Take(5)
                .OrderByDescending(a=>a.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var user in sortedUsers)
            {
                Console.WriteLine(user.Key);
            }
        }
    }
}
