using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Patterns
    {
        // Matrix[int N]
        // calculate diagonal
        // cycle 0 to n-2
        // inside cycle n-4
        // if pattern found once, next pattern's A must be greater from first pattern A

        static void Main()
        {
            //input and make matrix
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] tokenInput = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = tokenInput[j];
                }
            }
            //PrintMatrix(matrix, n);
            long currentMaxValue = long.MinValue;
            long currentMaxA = long.MinValue;
            for (int i = 0; i <= n - 3; i++)
            {
                for (int j = 0; j <= n - 5; j++)
                {
                    if (currentMaxA < matrix[i, j])
                    {
                        long temp = GetMatrixSum(matrix, n, i, j);
                        if (temp>long.MinValue)
                        {
                            currentMaxValue = temp;
                            currentMaxA = matrix[i, j];
                        }
                    }
                }
            }
            if (currentMaxA > long.MinValue)
            {
                Console.WriteLine("YES {0}", currentMaxValue);
            }
            else
            {
                //get diagonal sum

                Console.WriteLine("NO {0}", GetDiagonaSum(matrix, n));
            }
        }
        static long GetDiagonaSum(int[,] matrix, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        static long GetMatrixSum(int[,] matrix, int n, int i, int j)
        {
            long sum = long.MinValue;
            if (matrix[i, j] + 1 == matrix[i, j + 1]
                && matrix[i, j] + 2 == matrix[i, j +2]
                && matrix[i, j] + 3 == matrix[i + 1, j + 2]
                && matrix[i, j] + 4 == matrix[i + 2, j + 2]
                && matrix[i, j] + 5 == matrix[i + 2, j + 3]
                && matrix[i, j] + 6 == matrix[i + 2, j + 4])
            {
                sum = matrix[i, j] * 7 + 21;
            }
            return sum;
        }
        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
