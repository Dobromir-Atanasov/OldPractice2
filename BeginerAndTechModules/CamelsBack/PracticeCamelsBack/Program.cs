using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitSeparator = new char[] { ' ' };
            List<int> buildings = Console.ReadLine()
                .Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int camelSize = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (buildings.Count>camelSize)
            {
                buildings.RemoveAt(buildings.Count - 1);
                buildings.RemoveAt(0);
                rounds++;
            }

            if (rounds>0)
            {
                Console.WriteLine(rounds + " rounds");
                Console.WriteLine("remaining: " + string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine("already stable: " + string.Join(" ", buildings));
            }
        }
    }
}
