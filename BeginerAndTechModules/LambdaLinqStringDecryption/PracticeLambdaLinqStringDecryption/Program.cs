using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqStringDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputTokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int m = inputTokens[0];
            int n = inputTokens[1];

            inputTokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(x=>x>=65&&x<=90)
                .Skip(m)
                .Take(n)
                .ToArray();

            foreach (var item in inputTokens)
            {
                Console.Write((char)item);
            }
        }
    }
}
