using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbersWithoutNegatives = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    numbersWithoutNegatives.Add(numbers[i]);
                }
            }
            numbersWithoutNegatives.Reverse();
            if (numbersWithoutNegatives.Count>0)
            {
                foreach (var item in numbersWithoutNegatives)
                {
                    Console.Write("{0} ", item);
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
