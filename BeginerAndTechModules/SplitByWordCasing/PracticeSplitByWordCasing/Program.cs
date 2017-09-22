using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitChars = new char[]
            { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };

            List<string> str = Console.ReadLine()
                .Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var item in str)
            {
                if (item.All(char.IsLower))
                {
                    lowerCase.Add(item);
                }
                else if (item.All(char.IsUpper))
                {
                    upperCase.Add(item);
                }
                else
                {
                    mixedCase.Add(item);
                }
            }
            
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}