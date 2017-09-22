using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            HashSet<string> setTokens = new HashSet<string>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] tokenInput = Console.ReadLine().Split(' ').ToArray();
                foreach (var token in tokenInput)
                {
                    setTokens.Add(token);
                }
            }
            Console.WriteLine(string.Join(" ", setTokens.Select(x=>x).OrderBy(x=>x)));
        }
    }
}
