using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            string[] tokenInput = Console.ReadLine().Split(' ');
            int rowCount = int.Parse(tokenInput[0]);
            int colCount = int.Parse(tokenInput[1]);
            string[,] matrix = new string[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                string c1 = ((char)(i + 97)).ToString();
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = ((char)(i + 97)).ToString() + ((char)(i + j + 97)).ToString() + ((char)(i + 97)).ToString();
                }
            }
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    output.Append(matrix[i, j]);
                    output.Append(" ");
                }
                Console.WriteLine(output);
                output.Clear();
            }
        }
    }
}
