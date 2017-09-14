using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3TilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data
            double squareWidth = double.Parse(Console.ReadLine());
            double squareArea = squareWidth * squareWidth;
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double tileArea = tileWidth*tileHeight;
            double benchWight = double.Parse(Console.ReadLine());
            double benchHeight = double.Parse(Console.ReadLine());
            double benchArea = benchWight*benchHeight;
            double totalTilePieces = 0;
            double totalTimeNeeded = 0;
            totalTilePieces = (squareArea - benchArea) / tileArea;
            totalTimeNeeded = totalTilePieces * 0.2;
            Console.WriteLine("{0:f2}",totalTilePieces);
            Console.WriteLine("{0:f2}", totalTimeNeeded);
        }
    }
}
