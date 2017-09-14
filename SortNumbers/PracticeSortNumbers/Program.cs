using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> dataInput = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            dataInput.Sort();
            Console.WriteLine(string.Join(" <= ", dataInput));
        }
    }
}
