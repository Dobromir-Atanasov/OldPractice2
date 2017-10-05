using System;
using System.Linq;

namespace LowerOfThree
{
    class LowerOfThree
    {
        static void Main(string[] args)
        {
            int[] dimensionsOfMatrix = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool[,] matrix = new bool[(dimensionsOfMatrix[0])+1, (dimensionsOfMatrix[1]/2)+1]; //only diagonals can be used, so half of the matrix is unused
            int numberOfDirectionsToMove = int.Parse(Console.ReadLine());
            int result = 0;
            int currentR = 0;
            int currentC = 0;
            string[] tokenInput = new string[1];
            string direction = string.Empty;
            int numberOfSteps = 0;
            int deltaRow = 0;
            int deltaCol = 0;
            for (int i = 0; i < numberOfDirectionsToMove; i++)
            {
                tokenInput = Console.ReadLine()
                    .Split()
                    .ToArray();
                direction = tokenInput[0];
                numberOfSteps = int.Parse(tokenInput[1]);
                for (int moves = 1; moves < numberOfSteps; moves++)
                {
                    deltaRow = direction.Contains('U') ? 1 : -1;
                    deltaCol = direction.Contains('L') ? -1 : 1;
                    if ((currentR + deltaRow) >= 0 && (currentR + deltaRow) < dimensionsOfMatrix[0] && (currentC + deltaCol) >= 0 && (currentC + deltaCol) < dimensionsOfMatrix[1])
                    {
                        currentR += deltaRow;
                        currentC += deltaCol;
                        if (!matrix[currentR, currentC/2]) //if number not used yet
                        {
                            result += ((currentR + currentC) * 3);
                        }
                        matrix[currentR, currentC/2] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
