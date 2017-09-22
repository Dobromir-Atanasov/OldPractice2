using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinqFoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length/4; //from 4*k integers

            int[] raw1L = new int[k];
            raw1L = input.Take(k).Reverse().ToArray();

            int[] raw1R = new int[k];
            raw1R = input.Skip(3 * k).Take(k).ToArray();

            int[] result0 = new int[2 * k];

            result0 = raw1L.Take(k).ToArray();
            result0 = raw1R.Take(k).ToArray();

            int[] result1 = new int[k*2];

            result1 = input.Skip(k).Take(2 * k).ToArray();

            int[] result = new int[2 * k];

            result = result0.Concat(result1).ToArray();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
