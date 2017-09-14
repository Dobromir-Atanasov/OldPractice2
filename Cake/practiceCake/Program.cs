using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeSideX = int.Parse(Console.ReadLine());
            int cakeSideY = int.Parse(Console.ReadLine());
            int cakeSize = cakeSideX * cakeSideY;
            bool exitTime = false;

            string tokenInput = Console.ReadLine();

            while (tokenInput != "STOP"&&!exitTime)
            {
                int piecesTaken = int.Parse(tokenInput);
                cakeSize -= piecesTaken;
                if (cakeSize<0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", cakeSize*-1);
                    exitTime = true;
                    break;
                }
                tokenInput = Console.ReadLine();
            }
            if (!exitTime)
            {
                Console.WriteLine("{0} pieces are left.", cakeSize);
            }
        }
    }
}
