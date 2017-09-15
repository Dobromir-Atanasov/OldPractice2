using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    class ReverseNumbersWithAStack
    {
        static void Main(string[] args)
        {
            int[] tokensInput = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Stack<int> result = new Stack<int>();
            foreach (var token in tokensInput)
            {
                result.Push(token);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}