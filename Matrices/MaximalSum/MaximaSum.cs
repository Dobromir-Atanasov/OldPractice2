using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximaSum
    {
        static void Main(string[] args)
        {
            string[] tokenInput = Console.ReadLine().Split(' ');
            int rowSize = int.Parse(tokenInput[0]);
            int colSize = int.Parse(tokenInput[1]);
            int[,] matrix = new int[rowSize, colSize];
            int[] token = new int[colSize];
            for (int i = 0; i < rowSize; i++)
            {
                token = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
                for (int j = 0; j < colSize; j++)
                {
                    matrix[i, j] = token[j];
                }
            }
            int[,] matrixResult = new int[3, 3];
            int maxSum = int.MinValue;
            int tempSum = int.MinValue;
            for (int i = 0; i < rowSize-2; i++)
            {
                for (int j = 0; j < colSize-2; j++)
                {
                    tempSum = matrix[i, j] + matrix[i, j+1] + matrix[i, j+2] + matrix[i+1, j] + matrix[i+1, j+1] + matrix[i+1, j+2] + matrix[i+2, j] + matrix[i+2, j+1] + matrix[i+2, j+2];
                    if (tempSum>maxSum)
                    {
                        maxSum = tempSum;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                matrixResult[k, l] = matrix[i + k, j + l];
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} {1} {2}", matrixResult[i, 0], matrixResult[i,1], matrixResult[i,2]);
            }
        }
    }
}
