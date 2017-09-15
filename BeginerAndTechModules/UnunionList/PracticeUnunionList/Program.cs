using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUnunionList
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSeparator = new char[] { ' ' };
            List<int> primalList = Console.ReadLine()
                .Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int cycles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycles; i++)
            {
                List<int> sequence = Console.ReadLine()
                .Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
                for (int j = sequence.Count-1; j >= 0; j--)
                {
                    if (primalList.Contains(sequence[j]))
                    {
                        int itemToRemove = sequence[j];
                        primalList.RemoveAll(a => a == itemToRemove);
                        sequence.RemoveAll(a => a == itemToRemove);
                        j=sequence.Count;
                    }
                }
                foreach (var item in sequence)
                {
                    primalList.Add(item);
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
