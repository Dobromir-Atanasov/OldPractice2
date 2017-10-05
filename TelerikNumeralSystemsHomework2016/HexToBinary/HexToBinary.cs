using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBinary
{
    class HexToBinary
    {
        static void Main(string[] args)
        {
            string hexNumbers = "0123456789ABCDEF";

            string[] hexInBinary = new string[16];
            for (int i = 0; i < hexInBinary.Length; i++)
            {
                string temp = Convert.ToString((long)i, 2);
                int rest = temp.Length % 4;
                if (rest!=0)
                {
                    temp = new string('0', 4 - rest) + temp;
                }
                hexInBinary[i] = temp;
            }
            //Console.WriteLine(string.Join(" ", hexInBinary));

            string inputNumber = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < inputNumber.Length; i++)
            {
                result.Append(hexInBinary[hexNumbers.IndexOf(inputNumber[i])]);
            }
            //Judge don't like numbers starting with Zero, so we have to fix it
            while (result[0]=='0')
            {
                result.Remove(0, 1);
            }
            Console.WriteLine(result);
        }
    }
}
