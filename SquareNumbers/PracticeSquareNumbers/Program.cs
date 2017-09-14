using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeSortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dataInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> dataOutput = new List<int>();

            foreach (var item in dataInput)
            {
                if (Math.Sqrt(item)==(int)Math.Sqrt(item))
                {
                    dataOutput.Add(item);
                }
            }
            dataOutput.Sort((a,b) => b.CompareTo(a));
            foreach (var item in dataOutput)
            {
                Console.Write(item + " ");
            }
        }
    }
}
