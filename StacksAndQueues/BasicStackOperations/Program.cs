using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokensInput = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
            int amountOfElementsToPush = tokensInput[0];
            int amountOfElementsToPop = tokensInput[1];
            int elemntToCheckForExisting = tokensInput[2];
            Stack<int> elements = new Stack<int>(Console.ReadLine().Split(' ').Select(x => int.Parse(x)));
            for (int i = 0; i < amountOfElementsToPop; i++)
            {
                elements.Pop();
            }
            if (elements.Contains(elemntToCheckForExisting))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}
