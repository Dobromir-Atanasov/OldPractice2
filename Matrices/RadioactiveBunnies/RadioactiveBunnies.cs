using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            FillMatrix(matrixSize, matrix);

            //PrintMatrix(matrixSize, matrix);

            int playerPositionRow = -1;
            int playerPositionCol = -1;
            FindPlayerPosition(matrixSize, matrix, ref playerPositionRow, ref playerPositionCol);

            string movingCommands = Console.ReadLine();
            bool playerWon = false;
            bool playerDied = false;
            for (int step = 0; step < movingCommands.Length; step++)
            {
                PlayerMovement(matrixSize, matrix, ref playerPositionRow, ref playerPositionCol, movingCommands, ref playerWon, ref playerDied, step);
                if (playerWon)
                {
                    break;
                }
                if (playerDied)
                {
                    break;
                }
                //if stepped on dot -> bunny expand
                char[,] tempMatrix = new char[matrixSize[0], matrixSize[1]];
                for (int tempI = 0; tempI < matrixSize[0]; tempI++)
                {
                    for (int tempJ = 0; tempJ < matrixSize[1]; tempJ++)
                    {
                        tempMatrix[tempI, tempJ] = '.';
                    }
                }
                for (int i = 0; i < matrixSize[0]; i++)
                {
                    for (int j = 0; j < matrixSize[1]; j++)
                    {
                        if (matrix[i, j] == 'B')
                        {
                            if (i - 1 >= 0)
                            {
                                if (matrix[i - 1, j] == 'P')
                                {
                                    playerDied = true;
                                }
                                tempMatrix[i - 1, j] = 'B';
                            }
                            if (i + 1 < matrixSize[0])
                            {
                                if (matrix[i + 1, j] == 'P')
                                {
                                    playerDied = true;
                                }
                                tempMatrix[i + 1, j] = 'B';
                            }
                            if (j - 1 >= 0)
                            {
                                if (matrix[i, j - 1] == 'P')
                                {
                                    playerDied = true;
                                }
                                tempMatrix[i, j - 1] = 'B';
                            }
                            if (j + 1 < matrixSize[1])
                            {
                                if (matrix[i, j + 1] == 'P')
                                {
                                    playerDied = true;
                                }
                                tempMatrix[i, j + 1] = 'B';
                            }
                        }
                    }
                }
                //if bunny stepped on player = die

                if (playerDied)
                {
                    PrintMatrix(matrixSize, matrix);
                    Console.WriteLine("dead: {0} {1}", playerPositionRow, playerPositionCol);
                    break;
                }
                else
                {
                    matrix = tempMatrix;
                    matrix[playerPositionRow, playerPositionCol] = 'P';
                }
            }
        }

        private static void PlayerMovement(int[] matrixSize, char[,] matrix, ref int playerPositionRow, ref int playerPositionCol, string movingCommands, ref bool playerWon, ref bool playerDied, int step)
        {
            switch (movingCommands[step])
            {
                case 'U':
                    playerPositionRow -= 1;
                    //if outside = win
                    if (playerPositionRow < 0)
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("won: {0} {1}", playerPositionRow + 1, playerPositionCol);
                        playerWon = true;
                        break;
                    }
                    //if stepped on bunny = die
                    if (matrix[playerPositionRow, playerPositionCol] == 'B')
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("dead: {0} {1}", playerPositionRow + 1, playerPositionCol);
                        playerDied = true;
                        break;
                    }
                    break;
                case 'D':
                    playerPositionRow += 1;
                    //if outside = win
                    if (playerPositionRow == matrixSize[0])
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("won: {0} {1}", playerPositionRow - 1, playerPositionCol);
                        playerWon = true;
                        break;
                    }
                    //if stepped on bunny = die
                    if (matrix[playerPositionRow, playerPositionCol] == 'B')
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("dead: {0} {1}", playerPositionRow - 1, playerPositionCol);
                        playerDied = true;
                        break;
                    }
                    break;
                case 'L':
                    playerPositionCol -= 1;
                    //if outside = win
                    if (playerPositionCol < 0)
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("won: {0} {1}", playerPositionRow, playerPositionCol + 1);
                        playerWon = true;
                        break;
                    }
                    //if stepped on bunny = die
                    if (matrix[playerPositionRow, playerPositionCol] == 'B')
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("dead: {0} {1}", playerPositionRow, playerPositionCol + 1);
                        playerDied = true;
                        break;
                    }
                    break;
                case 'R':
                    playerPositionCol += 1;
                    //if outside = win
                    if (playerPositionCol == matrixSize[1])
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("won: {0} {1}", playerPositionRow, playerPositionCol - 1);
                        playerWon = true;
                        break;
                    }
                    //if stepped on bunny = die
                    if (matrix[playerPositionRow, playerPositionCol] == 'B')
                    {
                        PrintMatrix(matrixSize, matrix);
                        Console.WriteLine("dead: {0} {1}", playerPositionRow, playerPositionCol - 1);
                        playerDied = true;
                        break;
                    }
                    break;
                default:
                    break;
            }
        }

        private static void FindPlayerPosition(int[] matrixSize, char[,] matrix, ref int playerPositionRow, ref int playerPositionCol)
        {
            for (int i = 0; i < matrixSize[0]; i++)
            {
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    if (matrix[i, j] == 'P')
                    {
                        playerPositionRow = i;
                        playerPositionCol = j;
                        break;
                    }
                }
            }
        }

        private static void PrintMatrix(int[] matrixSize, char[,] matrix)
        {
            for (int i = 0; i < matrixSize[0]; i++)
            {
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[] matrixSize, char[,] matrix)
        {
            for (int i = 0; i < matrixSize[0]; i++)
            {
                string inputLine = Console.ReadLine();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    matrix[i, j] = inputLine[j];
                }
            }
        }
    }
}
