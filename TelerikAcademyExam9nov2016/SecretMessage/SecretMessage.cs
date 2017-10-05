using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretMessage
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            var input = new Queue<string>();
            string tokenInput = Console.ReadLine();
            while (tokenInput != "end")
            {
                input.Enqueue(tokenInput);
                tokenInput = Console.ReadLine();
            }
            int counter = input.Count;
            for (int i = 0; i < counter/3; i++)
            {
                int startIndex = int.Parse(input.Dequeue());
                int endIndex = int.Parse(input.Dequeue());
                string text = input.Dequeue();
                //Console.WriteLine("{0} {1} {2}", startIndex, endIndex, text);
                int step = 0;
                if (i % 2 == 0)
                {
                    step = 3;
                }
                else
                {
                    step = 4;
                }
                if (startIndex < 0)
                {
                    startIndex = text.Length + startIndex;
                }
                if (endIndex < 0)
                {
                    endIndex = text.Length + endIndex;
                }
                if (startIndex == endIndex)
                {
                    result.Append(text[startIndex]);
                }
                else
                {
                    for (int j = Math.Abs(startIndex); j <= Math.Abs(endIndex); j += step)
                    {
                        result.Append(text[j]);
                    }
                }
            }
            Console.WriteLine(result);
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
