using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            string hexDigits = "0123456789ABCDEF";

            string binNumber = Console.ReadLine();

            string result = string.Empty;

            while (binNumber.Length > 4)
            {
                string lastHexNumber = binNumber.Substring(binNumber.Length - 4);
                binNumber = binNumber.Remove(binNumber.Length - 4);
                result = hexDigits[Convert.ToInt16(lastHexNumber, 2)] + result;
            }
            result = hexDigits[Convert.ToInt16(binNumber, 2)] + result;
            Console.WriteLine(result);
        }
    }
}
