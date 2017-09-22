using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dataInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Dictionary<int, int> dataOutput = new Dictionary<int, int>();

            foreach (var item in dataInput)
            {
                if (dataOutput.ContainsKey(item))
                {
                    dataOutput[item] += 1;
                }
                else
                {
                    dataOutput.Add(item, 1);
                }
            }
            var ordered = dataOutput.OrderBy(key => key.Key);
            foreach (var item in ordered)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
