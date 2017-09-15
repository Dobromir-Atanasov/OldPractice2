using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasiqQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokensInput = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int amountOfElements = int.Parse(tokensInput[0]);
            int amountOfElmentsToDequeue = int.Parse(tokensInput[1]);
            int elementToCheck = int.Parse(tokensInput[2]);

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            Queue<int> elements = new Queue<int>(numbers);
            for (int i = 0; i < amountOfElmentsToDequeue; i++)
            {
                elements.Dequeue();
            }
            if (elements.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else if (elements.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}
