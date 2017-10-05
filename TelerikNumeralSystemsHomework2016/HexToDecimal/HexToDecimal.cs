using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string hexNumbers = "0123456789ABCDEF";

            char[] hexInput = Console.ReadLine().ToArray();

            ulong result = 0;

            for (int i = 0; i < hexInput.Length; i++)
            {
                result = result * 16 +(ulong)hexNumbers.IndexOf(hexInput[i]);
            }
            Console.WriteLine(result);
        }
    }
}
