using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAbsoluteDifference
{
    class IncreasingAbsoluteDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] seq = Console.ReadLine().Split().Select(long.Parse).ToArray();
                bool isSequenceOkey = true;
                long firstAbsDiff = Math.Abs(seq[0] - seq[1]);
                long nextDiff = 0;
                for (int index = 1; index < seq.Length-1; index++)
                {
                    nextDiff = Math.Abs(seq[index] - seq[index + 1]);
                    if (firstAbsDiff<=nextDiff&&Math.Abs(firstAbsDiff - nextDiff)<=1)
                    {
                        firstAbsDiff = nextDiff;
                    }
                    else
                    {
                        isSequenceOkey = false;
                        break;
                    }
                }
                Console.WriteLine(isSequenceOkey);
            }
        }
    }
}
