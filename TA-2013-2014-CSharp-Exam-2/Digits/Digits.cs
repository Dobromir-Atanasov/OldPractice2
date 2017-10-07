using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[10];
            byte[,] matrix = new byte[n, n];
            for (int i = 0; i < n; i++)
            {
                byte[] tokenInput = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(byte.Parse)
                    .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = tokenInput[j];
                }
            }
            for (int row = 0; row < n - 4; row++)
            {
                for (int col = 0; col < n - 2; col++)
                {
                    //no need to check for Zero since N*0 = 0
                    if (matrix[row, col + 2] == 1
                && matrix[row + 1, col + 1] == 1 && matrix[row + 1, col + 2] == 1
                && matrix[row + 2, col] == 1 && matrix[row + 2, col + 2] == 1
                && matrix[row + 3, col + 2] == 1
                && matrix[row + 4, col + 2] == 1)
                    {
                        results[1]++;
                    }
                    else if (matrix[row, col + 1] == 2
                && matrix[row + 1, col] == 2 && matrix[row + 1, col + 2] == 2
                && matrix[row + 2, col + 2] == 2
                && matrix[row + 3, col + 1] == 2
                && matrix[row + 4, col] == 2 && matrix[row + 4, col + 1] == 2 && matrix[row + 4, col + 2] == 2)
                    {
                        results[2]++;
                    }
                    else if (matrix[row, col] == 3 && matrix[row, col + 1] == 3 && matrix[row, col + 2] == 3
                && matrix[row + 1, col + 2] == 3
                && matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3
                && matrix[row + 3, col + 2] == 3
                 && matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3)
                    {
                        results[3]++;
                    }
                    else if (matrix[row, col] == 4 && matrix[row, col + 2] == 4
                && matrix[row + 1, col] == 4 && matrix[row + 1, col + 2] == 4
                && matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4
                && matrix[row + 3, col + 2] == 4
                && matrix[row + 4, col + 2] == 4)
                    {
                        results[4]++;
                    }
                    else if (matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5
                && matrix[row + 1, col] == 5
                && matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5
                && matrix[row + 3, col + 2] == 5
                && matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5)
                    {
                        results[5]++;
                    }
                    else if (matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6
                && matrix[row + 1, col] == 6
                && matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6
                && matrix[row + 3, col] == 6 && matrix[row + 3, col + 2] == 6
                && matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6)
                    {
                        results[6]++;
                    }
                    else if (matrix[row, col] == 7 && matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7
                && matrix[row + 1, col + 2] == 7
                && matrix[row + 2, col + 1] == 7
                && matrix[row + 3, col + 1] == 7
                && matrix[row + 4, col + 1] == 7)
                    {
                        results[7]++;
                    }
                    else if (matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8
                && matrix[row + 1, col] == 8 && matrix[row + 1, col + 2] == 8
                && matrix[row + 2, col + 1] == 8
                && matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8
                && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8)
                    {
                        results[8]++;
                    }
                    else if (matrix[row, col] == 9 && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9
                && matrix[row + 1, col] == 9 && matrix[row + 1, col + 2] == 9
                && matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9
                && matrix[row + 3, col + 2] == 9
                && matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 && matrix[row + 4, col + 2] == 9)
                    {
                        results[9]++;
                    }
                }
            }
            long totalSum = 0;
            for (int number = 0; number < 10; number++)
            {
                totalSum += results[number] * number;
            }
            Console.WriteLine(totalSum);
        }
        //Using methods slows the program by ~10%, so I'm forced to move checking

        //define matrixes of digits
        //static bool CheckForOne(int[,] matrix, int row, int col)
        //{
        //    return matrix[row, col + 2] == 1
        //        && matrix[row + 1, col + 1] == 1 && matrix[row + 1, col + 2] == 1
        //        && matrix[row + 2, col] == 1 && matrix[row + 2, col + 2] == 1
        //        && matrix[row + 3, col + 2] == 1
        //        && matrix[row + 4, col + 2] == 1;
        //}
        //static bool CheckForTwo(int[,] matrix, int row, int col)
        //{
        //    return matrix[row, col + 1] == 2
        //        && matrix[row + 1, col] == 2 && matrix[row + 1, col + 2] == 2
        //        && matrix[row + 2, col + 2] == 2
        //        && matrix[row + 3, col + 1] == 2
        //        && matrix[row + 4, col] == 2 && matrix[row + 4, col + 1] == 2 && matrix[row + 4, col + 2] == 2;
        //}
        //static bool CheckForThree(int[,] matrix, int row, int col)
        //{
        //    return
        //        matrix[row, col] == 3 && matrix[row, col + 1] == 3 && matrix[row, col + 2] == 3
        //        && matrix[row + 1, col + 2] == 3
        //        && matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3
        //        && matrix[row + 3, col + 2] == 3
        //         && matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3;
        //    ;
        //}
        //static bool CheckForFour(int[,] matrix, int row, int col)
        //{
        //    return matrix[row, col] == 4 && matrix[row, col + 2] == 4
        //        && matrix[row + 1, col] == 4 && matrix[row + 1, col + 2] == 4
        //        && matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4
        //        && matrix[row + 3, col + 2] == 4
        //        && matrix[row + 4, col + 2] == 4;
        //}
        //static bool CheckForFive(int[,] matrix, int row, int col)
        //{
        //    return
        //           matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5
        //        && matrix[row + 1, col] == 5
        //        && matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5
        //        && matrix[row + 3, col + 2] == 5
        //        && matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5;
        //}
        //static bool CheckForSix(int[,] matrix, int row, int col)
        //{
        //    return
        //        matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6
        //        && matrix[row + 1, col] == 6
        //        && matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6
        //        && matrix[row + 3, col] == 6 && matrix[row + 3, col + 2] == 6
        //        && matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6;
        //}
        //static bool CheckForSeven(int[,] matrix, int row, int col)
        //{
        //    return
        //        matrix[row, col] == 7 && matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7
        //        && matrix[row + 1, col + 2] == 7
        //        && matrix[row + 2, col + 1] == 7
        //        && matrix[row + 3, col + 1] == 7
        //        && matrix[row + 4, col + 1] == 7;
        //}
        //static bool CheckForEight(int[,] matrix, int row, int col)
        //{
        //    return
        //        matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8
        //        && matrix[row + 1, col] == 8 && matrix[row + 1, col + 2] == 8
        //        && matrix[row + 2, col + 1] == 8
        //        && matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8
        //        && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8;
        //}
        //static bool CheckForNine(int[,] matrix, int row, int col)
        //{
        //    return
        //        matrix[row, col] == 9 && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9
        //        && matrix[row + 1, col] == 9 && matrix[row + 1, col + 2] == 9
        //        && matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9
        //        && matrix[row + 3, col + 2] == 9
        //        && matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 && matrix[row + 4, col + 2] == 9;
        //}
    }
}
