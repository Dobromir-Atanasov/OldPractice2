using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            string[] rowColToken = Console.ReadLine().Split(' ');
            int rowCount = int.Parse(rowColToken[0]);
            int colCount = int.Parse(rowColToken[1]);
            char[,] matrix = new char[rowCount, colCount];
            char[] tokenInput = new char[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                tokenInput = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x[0])
                    .ToArray();
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = tokenInput[j];
                }
            }
            int counter = 0;
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < colCount - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j] && matrix[i + 1, j] == matrix[i, j + 1] && matrix[i, j + 1] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
