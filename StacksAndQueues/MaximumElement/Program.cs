using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        public static Stack<int> tokens = new Stack<int>();

        static void Main(string[] args)
            //Judge timedOut. Probably I need to find beter way to handle finding Max number in the Stack!
        {
            int queriesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < queriesCount; i++)
            {
                string token = Console.ReadLine();
                if (token=="3")
                {
                    tokens.TrimExcess();
                    Console.WriteLine(tokens.Max());
                }
                else if (token=="2")
                {
                    tokens.Pop();
                }
                else
                {
                    SplitAndPut(token);
                }
            }
        }
        static void SplitAndPut(string token)
        {
            int commandAndSpaceRemoved = int.Parse(token.Remove(0, 2));
            tokens.Push(commandAndSpaceRemoved);
        }
    }
}