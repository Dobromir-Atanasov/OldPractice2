using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDifferences
{
    class EvenDifferences
    {
        static void Main(string[] args)
        {
            long[] tokenInput = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x))
                .ToArray();
            //Console.WriteLine(string.Join(" ", tokenInput));
            int currentIndex = 1;
            long result = 0;
            while (currentIndex > 0 && currentIndex < tokenInput.Length)
            {
                long diff = Math.Abs( tokenInput[currentIndex] - tokenInput[currentIndex - 1]);

                //is even or odd
                if (diff % 2 == 0)
                {
                    //even jump
                    currentIndex += 2;
                    //going after result
                    result += diff;
                }
                else
                {
                    //odd jump
                    currentIndex += 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
