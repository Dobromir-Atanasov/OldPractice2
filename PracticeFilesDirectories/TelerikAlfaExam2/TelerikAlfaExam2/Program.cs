using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAlfaExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tokenInput = new int[n];
            for (int i = 0; i < n; i++)
            {
                tokenInput[i] = int.Parse(Console.ReadLine());
            }
            int[] resultMerged = new int[n - 1];
            for (int i = 0; i < n-1; i++)
            {
                int first = tokenInput[i]%10;
                int second = tokenInput[i + 1]/10;
                resultMerged[i] = first * 10 + second;
            }
            Console.WriteLine(string.Join(" ", resultMerged));

            int[] resultSplashed = new int[n - 1];
            for (int i = 0; i < n-1; i++)
            {
                int first = tokenInput[i] / 10;
                int last = tokenInput[i + 1] % 10;
                int mid1 = tokenInput[i] % 10;
                int mid2 = tokenInput[i + 1] / 10;
                int midSum = (mid1 + mid2) % 10;
                resultSplashed[i] = first * 100 + midSum * 10 + last;
            }
            Console.WriteLine(string.Join(" ", resultSplashed));

        }
    }
}
