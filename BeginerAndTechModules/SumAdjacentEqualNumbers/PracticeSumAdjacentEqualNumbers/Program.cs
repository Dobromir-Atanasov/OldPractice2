using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] *= 2;
                    inputList.RemoveAt(i + 1);
                    i = -1;
                }
            }
            foreach (var item in inputList)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
