using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLambdaLinqArrayData
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            //remove smaller then average
            double inputAverage = input.Average();

            List<int> numbersLeft = input.Where(x => x >= inputAverage).ToList();

            string whatToDo = Console.ReadLine();

            switch (whatToDo)
            {
                case "Min":
                    Console.WriteLine(numbersLeft.Min());
                    return;
                case "Max":
                    Console.WriteLine(numbersLeft.Max());
                    return;
                case "All":
                    foreach (var item in numbersLeft.OrderBy(x=>x))
                    {
                        Console.Write("{0} ", item);
                    }
                    return;
                default:
                    break;
            }
        }
    }
}
