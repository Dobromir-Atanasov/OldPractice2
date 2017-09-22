using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinqLargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();

            numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> result = numbers.OrderByDescending(x => x).Take(3).ToList();

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
