using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            long[] tokenInput = new long[matrixSize];
            long firstDiagonal = 0;
            long secondDiagonal = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                tokenInput = Console.ReadLine().Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
                firstDiagonal += tokenInput[i];
                secondDiagonal += tokenInput[matrixSize - 1 - i];
            }
            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
        }
    }
}
