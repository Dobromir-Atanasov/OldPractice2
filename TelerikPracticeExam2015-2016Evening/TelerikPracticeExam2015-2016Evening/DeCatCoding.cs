using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPracticeExam2015_2016Evening
{
    class DeCatCoding
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ulong.MaxValue);
            //input
            string[] tokenInput = Console.ReadLine()
                .Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //convert to Decimal
            ulong decResult = 0;
            List<string> result = new List<string>();
            foreach (var word in tokenInput)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    decResult += (ulong)((ulong)(word[i] - 'a') * (ulong)Math.Pow(21, (word.Length - 1 - i)));
                }
                string sb = string.Empty;
                while (decResult > 0)
                {
                    sb = ((char)(decResult % 26 + 'a')) + sb;
                    decResult /= 26;
                }

                //print
                result.Add(sb);

            }

            Console.WriteLine(string.Join(" ", result));
 
            //convert to 26 based
        }
    }
}
