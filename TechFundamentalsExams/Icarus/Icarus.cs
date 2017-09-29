using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Icarus
    {
        // 100/100 points
        static void Main(string[] args)
        {
            int power = 1;
            int[] plane = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
            int startingIndex = int.Parse(Console.ReadLine());
            string token = Console.ReadLine();
            while (token!="Supernova")
            {
                string[] command = token.Split();
                if (command[0]=="left")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        startingIndex--;
                        if (startingIndex<0)
                        {
                            startingIndex = plane.Length - 1;
                            power++;
                        }
                        plane[startingIndex] -= power;
                    }
                }
                if (command[0]=="right")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        startingIndex++;
                        if (startingIndex>plane.Length-1)
                        {
                            startingIndex = 0;
                            power++;
                        }
                        plane[startingIndex] -= power;
                    }
                }

                token = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
