using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDictionariesLetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputData = Console.ReadLine().ToCharArray().ToList();
            // Console.WriteLine("{0} {1}", inputData[0], inputData[1]);

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char item in inputData)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
