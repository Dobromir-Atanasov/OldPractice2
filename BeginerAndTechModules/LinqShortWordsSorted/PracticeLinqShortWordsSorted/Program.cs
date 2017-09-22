using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinqShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] splitters = new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> words = input
                .ToLower()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length<5)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
