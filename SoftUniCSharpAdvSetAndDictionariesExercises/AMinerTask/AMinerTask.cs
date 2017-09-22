using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var valet = new Dictionary<string, long>();
            string firstToken = Console.ReadLine();
            int secondToken = 0;
            while (firstToken.ToLower()!="stop")
            {
                secondToken = int.Parse(Console.ReadLine());
                if (!valet.ContainsKey(firstToken))
                {
                    valet.Add(firstToken, secondToken);
                }
                else
                {
                    valet[firstToken] += secondToken;
                }
            firstToken = Console.ReadLine();
            }
            foreach (var tresure in valet)
            {
                Console.WriteLine("{0} -> {1}", tresure.Key, tresure.Value);
            }
        }
    }
}
