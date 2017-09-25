using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokenInput = Console.ReadLine().Split(' ');
            int numberOfRows = int.Parse(tokenInput[0]);
            int numberOfColumns = int.Parse(tokenInput[1]);
            char[,] matrix = new char[numberOfRows, numberOfColumns];
            string snake = Console.ReadLine();

            FillMatrix(numberOfRows, numberOfColumns, matrix, snake);

            string[] shotInput = Console.ReadLine().Split(' ');
            int impactRow = int.Parse(shotInput[0]);
            int impactCol = int.Parse(shotInput[1]);
            int impactRadius = int.Parse(shotInput[2]);

            MakeShot(numberOfRows, numberOfColumns, matrix, impactRow, impactCol, impactRadius);

            Compact(numberOfRows, numberOfColumns, matrix);

            PrintMatrix(numberOfRows, numberOfColumns, matrix);

        }

        private static void Compact(int numberOfRows, int numberOfColumns, char[,] matrix)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                Queue<char> currentColumn = new Queue<char>();
                for (int row = numberOfRows - 1; row >= 0; row--)
                {
                    if (matrix[row, col] != ' ')
                    {
                        currentColumn.Enqueue(matrix[row, col]);
                    }
                    matrix[row, col] = ' ';
                    currentColumn.TrimExcess();
                }
                int numberOfElements = currentColumn.Count();
                for (int row = numberOfRows - 1; row >= numberOfRows - 1 - numberOfElements; row--)
                {
                    if (currentColumn.Count == 0) //Too lazy to think.
                    {
                        break;
                    }

                    matrix[row, col] = currentColumn.Dequeue();
                }
            }
        }

        private static void MakeShot(int numberOfRows, int numberOfColumns, char[,] matrix, int impactRow, int impactCol, int impactRadius)
        {
            //(x-center_x)^2 + (y-center_y)^2 < radius ^2

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    if ((row - impactRow) * (row - impactRow) + (col - impactCol) * (col - impactCol) <= impactRadius * impactRadius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static void PrintMatrix(int numberOfRows, int numberOfColumns, char[,] matrix)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int numberOfRows, int numberOfColumns, char[,] matrix, string snake)
        {
            bool isMovingLeft = true;
            int counter = 0;
            for (int row = numberOfRows - 1; row >= 0; row--)
            {
                if (isMovingLeft)
                {
                    for (int col = numberOfColumns - 1; col >= 0; col--)
                    {
                        if (counter >= snake.Length)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = snake[counter];
                        counter++;
                    }
                }
                else
                {
                    for (int col = 0; col < numberOfColumns; col++)
                    {
                        if (counter >= snake.Length)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = snake[counter];
                        counter++;
                    }
                }
                isMovingLeft = !isMovingLeft;
            }
        }
    }
}
