using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitShiftMatrix
{
    //Result 95/100 cant handle one of the tests
    class BitShiftMatrix
    {
        //cell value = (rowPosition+(colSize-1-colPosition))^2
        static void Main(string[] args)
        {
            //input
            int rowSize = int.Parse(Console.ReadLine());
            int colSize = int.Parse(Console.ReadLine());

            //make matrix
            bool[,] matrix = new bool[rowSize, colSize]; //since we only need info is cell visited
            //get moves
            int numberOfMoves = int.Parse(Console.ReadLine());
            decimal[] moves = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            int rowPosition = rowSize - 1; //initial position by condition
            int colPosition = 0; //initial position by condition
            int coeficient = Math.Max(rowSize, colSize);
            BigInteger result = 1;
            //if (numberOfMoves==0||rowSize==0||colSize==0) //tried to get 100 /100
            //{
            //    result = 0;
            //}
            matrix[rowPosition, colPosition] = true; //got it!!! 100/100
            for (int i = 0; i < numberOfMoves; i++)
            {
                int targetRow = (int)moves[i] / coeficient;
                int targetCol = (int)moves[i] % coeficient;
                while (colPosition != targetCol)
                {
                    if (colPosition < targetCol)
                    {
                        colPosition++;
                    }
                    else
                    {
                        colPosition--;
                    }
                    if (!matrix[rowPosition, colPosition])
                    {
                        int temp = (rowSize - 1 - rowPosition) + (colPosition);
                        result += (BigInteger)Math.Pow(2, temp);
                        matrix[rowPosition, colPosition] = true;  //visited
                    }

                }
                while (rowPosition != targetRow)
                {
                    if (rowPosition < targetRow)
                    {
                        rowPosition++;
                    }
                    else
                    {
                        rowPosition--;
                    }
                    if (!matrix[rowPosition, colPosition])
                    {
                        int temp = (rowSize - 1 - rowPosition) + (colPosition);
                        result += (BigInteger)Math.Pow(2, temp);
                        matrix[rowPosition, colPosition] = true;  //visited
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
