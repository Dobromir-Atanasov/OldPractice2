using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        ulong numberInput = ulong.Parse(Console.ReadLine());
        string result = string.Empty;
        while (numberInput>0)
        {
            byte reminder = (byte)(numberInput % 2);
            numberInput /= 2;
            if (reminder==0)
            {
                result = '0' + result;
            }
            else
            {
                result = '1' + result;
            }
        }
        Console.WriteLine(result);
    }
}

