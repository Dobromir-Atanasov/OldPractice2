using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingNumbers
{
    class MergingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var merged = new int[n - 1];
            var summed = new int[n - 1];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                merged[i] = (numbers[i] % 10) * 10 + numbers[i + 1] / 10;
                summed[i] = numbers[i] + numbers[i + 1];
            }
            Console.WriteLine(string.Join(" ", merged));
            Console.WriteLine(string.Join(" ", summed));
        }
    }
}
