using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3KinghtGame
{
    class Program
    {
        public static bool[,] array;
        public static int boardSize;

        static void InputConsoleData()
        {
            for (int i = 2; i < boardSize + 2; i++)
            {
                string tempLine = Console.ReadLine();
                for (int j = 2; j < boardSize + 2; j++)
                {
                    if (tempLine[j - 2] == 'K')
                    {
                        array[i, j] = true;
                    }
                }
            }
        }
        static void PrintArray()
        {
            for (int i = 0; i < boardSize + 4; i++)
            {
                for (int j = 0; j < boardSize + 4; j++)
                {
                    Console.Write("\t" + array[i, j]);
                }
                Console.WriteLine();
            }
        }
        // static void


        static void Main(string[] args)
        {
            boardSize = int.Parse(Console.ReadLine());
            array = new bool[boardSize + 4, boardSize + 4];
            InputConsoleData();
            //for (int i = 2; 2 < boardSize + 2; i++)
            //{
            //    for (int j = 2; j < boardSize + 2; j++)
            //    {
            //        KillKnights(i, j);
            //    }
            //}
            //PrintArray();

        }
    }
}
