using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rowsGiven = int.Parse(Console.ReadLine());
            int[][] firstArray = new int[rowsGiven][];
            int[][] secondArray = new int[rowsGiven][];
            int elementsCounter = 0;
            for (int i = 0; i < rowsGiven; i++)
            {
                int[] tokenInputOne = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                firstArray[i] = tokenInputOne;
                elementsCounter += tokenInputOne.Length;
            }
            for (int i = 0; i < rowsGiven; i++)
            {
                int[] tokenInputTwo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
                secondArray[i] = tokenInputTwo;
                elementsCounter += tokenInputTwo.Length;
            }
            bool areArraysMatching = true;
            int firstLineLenght = firstArray[0].Length + secondArray[0].Length;
            for (int i = 1; i < rowsGiven; i++)
            {
                if (firstArray[i].Length + secondArray[i].Length != firstLineLenght)
                {
                    areArraysMatching = false;
                    break;
                }
            }
            if (areArraysMatching)
            {
                for (int rows = 0; rows < rowsGiven; rows++)
                {
                    Console.WriteLine("[{0}, {1}]", string.Join(", ", firstArray[rows]), string.Join(", ", secondArray[rows]));
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}", elementsCounter);
            }
        }
    }
}
